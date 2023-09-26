using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkThemeSyntax.Resources
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.actiprosoftware.com/langdef/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.actiprosoftware.com/langdef/1.0", IsNullable = false)]
    public partial class LanguageDefinition
    {

        private LanguageDefinitionClassificationType[] languageDefinitionClassificationTypesField;

        private string languageKeyField;

        private string languageDescriptionField;

        private string creatorField;

        private string copyrightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute("LanguageDefinition.ClassificationTypes")]
        [System.Xml.Serialization.XmlArrayItemAttribute("ClassificationType", IsNullable = false)]
        public LanguageDefinitionClassificationType[] LanguageDefinitionClassificationTypes
        {
            get
            {
                return this.languageDefinitionClassificationTypesField;
            }
            set
            {
                this.languageDefinitionClassificationTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LanguageKey
        {
            get
            {
                return this.languageKeyField;
            }
            set
            {
                this.languageKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LanguageDescription
        {
            get
            {
                return this.languageDescriptionField;
            }
            set
            {
                this.languageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Copyright
        {
            get
            {
                return this.copyrightField;
            }
            set
            {
                this.copyrightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.actiprosoftware.com/langdef/1.0")]
    public partial class LanguageDefinitionClassificationType
    {

        private string keyField;

        private string descriptionField;

        private string defaultStyleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultStyle
        {
            get
            {
                return this.defaultStyleField;
            }
            set
            {
                this.defaultStyleField = value;
            }
        }
    }


}
