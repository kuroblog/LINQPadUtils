﻿namespace LINQPadUtils.MetadataProviders
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    class EnumerableObjectTypeMetadataProvider : TypeMetadataProviderBase
    {
        public EnumerableObjectTypeMetadataProvider(object obj)
            : base(obj)
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

        public override sealed PropertyInfo[] Properties { get; protected set; }
    }
}