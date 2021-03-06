﻿namespace LINQPadUtils.MetadataProviders
{
    using System;
    using System.Reflection;

    class PrimitiveTypeMetadataProvider : TypeMetadataProviderBase
    {
        public PrimitiveTypeMetadataProvider(object obj, Type objType)
            : base(obj, objType)
        {
            this.Properties = new PropertyInfo[0];
        }

        public override bool IsEnumerableOfKnownType
        {
            get
            {
                return false;
            }
        }

        public override sealed MemberInfo[] Properties { get; protected set; }
    }
}