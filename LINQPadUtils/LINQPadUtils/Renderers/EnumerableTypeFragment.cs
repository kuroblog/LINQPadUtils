﻿namespace LINQPadUtils.Fragments
{
    using LINQPadUtils.MetadataProviders;

    class EnumerableTypeFragment : FragmentBase
    {
        public EnumerableTypeFragment(TypeMetadataProviderBase metadata)
            : base(metadata) { }

        public override string Render()
        {
            var tableBuilder = new TableBuilder(base.Metadata);

            FragmentBase rowRenderer = base.Metadata.IsEnumerableOfKnownType
                ? new EnumerableComplexObjectTableRowsFragment(base.Metadata)
                : base.Metadata.IsEnumerable && base.Metadata.IsPrimitiveElement
                    ? new PrimitiveEnumerableTableRowsFragment(base.Metadata) 
                    : base.Metadata.IsEnumerable
                        ? new EnumerableObjectTableRowsFragment(base.Metadata) as FragmentBase
                        : new ComplexObjectTableRowsFragment(base.Metadata);

            tableBuilder.AddFragment(new FragmentBase[]
            {
                new EnumerableTypeTableStartFragment(base.Metadata), 
                new EnumerableTypeTableHeadingFragment(base.Metadata),
                rowRenderer,
                new TableEndFragment(base.Metadata), 
            });

            return tableBuilder.ToString();
        }
    }
}