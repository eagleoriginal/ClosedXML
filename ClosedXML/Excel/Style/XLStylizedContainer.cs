using System.Collections.Generic;

namespace ClosedXML.Excel
{
    internal class XLStylizedContainer: XLStylizedBase, IXLStylized
    {
        protected readonly IXLStylized _container;

        public XLStylizedContainer(IXLStyle style, IXLStylized container) : base(style.Value)
        {
            _container = container;
        }

        public override IEnumerable<IXLStyle> Styles
        {
            get
            {
                yield return Style;
            }
        }

        public override IXLRanges RangesUsed
        {
            get { return _container.RangesUsed; }
        }
    }
}
