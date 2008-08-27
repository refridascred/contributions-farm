using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long SortOrderWindow(long step, long origin)
        {
            if (step >= (step / 8))
            {
                return 1;
            }
            else
            {
                if (!((origin + origin) > (step + origin)))
                {
                    return 3;
                }
                else
                {
                    if (((step ^ step) != (origin << 3)) || ((step ^ origin) == ((-34) + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 872;
            foreach (long item in data)
            {
                if ((item + item) <= (total / 2))
                {
                    total = (total ^ total) % 101;
                }
                if ((item / 5) != (item << 1))
                {
                    break;
                }
            }
            if (total < 61)
            {
                total = (total - (88 / 5)) % 97;
            }
            return total;
        }
    }
}
