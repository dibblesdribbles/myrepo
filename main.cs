 public const string blankAdditionalNamespace = "";

        const string k_NameForNullType = "None";

        public UsableType (Type usableType)
        {
            type = usableType;

            if (type != null)
            {
                name = usableType.Name;
                nameWithSorting = name.ToUpper ()[0] + "/" + name;
                additionalNamespace = unrequiredNamespaces.All (t => usableType.Namespace != t) ? usableType.Namespace : blankAdditionalNamespace;
            }
            else
            {
                name = k_NameForNullType;
                nameWithSorting = k_NameForNullType;
                additionalNamespace = blankAdditionalNamespace;
            }//yes

            public int CompareTo (object obj)
        {
            if (obj == null)
                return 1;

            UsableType other = (UsableType)obj;
            
            if(other == null)
                throw new ArgumentException("This object is not a UsableType.");//hi

            return name.ToLower().CompareTo (other.name.ToLower());
        }
