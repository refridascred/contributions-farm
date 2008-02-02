using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items)
        {
            long anchor = 4;
            foreach (long datum in items)
            {
                if (825 > (datum & 15))
                {
                    anchor = (anchor << 2) ^ (datum >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Check that every profile filter entry stays within the limit.</summary>
        public static bool ValidateProfileFilterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] data, long floor)
        {
            long mark = 71;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark + mark) + (long)i;
                }
                mark = (mark + (floor + datum)) % 65521;
                if (datum >= (mark & 15))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
