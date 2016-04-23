﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Security.Principal;
using Jhu.Graywulf.Util;

namespace Jhu.Graywulf.AccessControl
{
    public class Identity : IIdentity, ICloneable
    {
        #region Private member variables

        private string name;
        private string authenticationType;
        private bool isAuthenticated;
        private IdentityRoleCollection roles;

        #endregion
        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AuthenticationType
        {
            get { return authenticationType; }
            set { authenticationType = value; }
        }

        public bool IsAuthenticated
        {
            get { return isAuthenticated; }
            set { isAuthenticated = value; }
        }
        
        public IdentityRoleCollection Roles
        {
            get { return roles; }
        }

        #endregion
        #region Constructors and initializers

        public static Identity Public
        {
            // Authenticated but otherwise unknown
            get
            {
                return new Identity()
                {
                    isAuthenticated = true,
                };
            }
        }

        public static Identity Guest
        {
            // Not authenticated
            get
            {
                return new Identity()
                {
                    isAuthenticated = false,
                };
            }
        }

        public Identity()
        {
            InitializeMembers();
        }

        public Identity(Identity old)
        {
            CopyMembers(old);
        }

        private void InitializeMembers()
        {
            this.name = null;
            this.authenticationType = null;
            this.isAuthenticated = false;
            this.roles = new IdentityRoleCollection();
        }

        private void CopyMembers(Identity old)
        {
            this.name = old.name;
            this.authenticationType = old.authenticationType;
            this.isAuthenticated = old.isAuthenticated;
            this.roles = new IdentityRoleCollection(old.roles);
        }

        public object Clone()
        {
            return new Identity(this);
        }

        #endregion

        public bool IsSame(string other)
        {
            return EntityAcl.Comparer.Compare(this.name, other) == 0;
        }

        public bool IsInRole(string group, string role)
        {
            // TODO: optimize this using hashtables

            foreach (var r in roles)
            {
                if (EntityAcl.Comparer.Compare(r.Group, group) == 0 &&
                    EntityAcl.Comparer.Compare(r.Role, role) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        #region Binary serialization

        public byte[] ToBinary()
        {
            using (var ms = new MemoryStream())
            {
                using (var w = new BinaryWriter(ms))
                {
                    ToBinary(w);
                }

                return ms.ToArray();
            }
        }

        public void ToBinary(BinaryWriter w)
        {
            w.Write('I');
            w.Write('D');
            w.Write((short)1);

            w.Write(isAuthenticated);

            w.WriteNullString(name);

            w.Write((short)roles.Count);

            foreach (var role in roles)
            {
                w.WriteNullString(role.Group);
                w.WriteNullString(role.Role);
            }
        }

        public static Identity FromBinary(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                using (var r = new BinaryReader(ms))
                {
                    return FromBinary(r);
                }
            }
        }

        public static Identity FromBinary(BinaryReader r)
        {
            var id = new Identity();

            r.ReadChar();
            r.ReadChar();
            r.ReadInt16();

            id.isAuthenticated = r.ReadBoolean();
            id.name = r.ReadNullString();

            int rc = (int)r.ReadInt16();

            for (int i = 0; i < rc; i++)
            {
                var role = new IdentityRole()
                {
                    Group = r.ReadNullString(),
                    Role = r.ReadNullString()
                };

                id.roles.Add(role);
            }

            return id;
        }

        #endregion
        #region XML serialization

        public string ToXml()
        {
            return Util.XmlConverter.ToXml(this, this.ToXml);
        }

        public void ToXml(Stream stream)
        {
            Util.XmlConverter.ToXml(this, stream, this.ToXml);
        }

        private void ToXml(XmlWriter w)
        {
            w.WriteStartElement("id");
            w.WriteAttributeString("name", name);
            w.WriteAttributeString("auth", IsAuthenticated ? "1" : "0");

            IdentityRole lastentry = null;

            foreach (var role in roles)
            {
                if (lastentry != null)
                {
                    w.WriteEndElement();
                }

                lastentry = role;

                w.WriteStartElement("group");
                w.WriteAttributeString("name", role.Group);
                w.WriteAttributeString("role", role.Role);
            }

            if (lastentry != null)
            {
                w.WriteEndElement();
            }

            w.WriteEndElement();
        }

        public static Identity FromXml(Stream stream)
        {
            return Util.XmlConverter.FromXml(stream, FromXml);
        }

        public static Identity FromXml(string xml)
        {
            return Util.XmlConverter.FromXml(xml, FromXml);
        }

        private static Identity FromXml(XmlReader r)
        {
            var id = new Identity();

            r.Read();   
            id.name = r.GetAttribute("name");
            id.isAuthenticated = r.GetAttribute("auth") == "1";
            r.ReadStartElement("id");

            // Read group and role membership
            while (r.NodeType == XmlNodeType.Element)
            {
                var role = new IdentityRole();
                role.Group = r.GetAttribute("name");
                role.Role = r.GetAttribute("role");

                id.roles.Add(role);

                r.Read();
            }

            if (r.NodeType == XmlNodeType.EndElement)
            {
                r.ReadEndElement();
            }

            return id;
        }

        #endregion
    }
}
