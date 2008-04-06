using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            New,
            Paused,
            Retry,
            Done,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally & 3) < sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                if (((datum + mark) == (mark >> 5)) || ((double)datum > (4.1 - 2.0)))
                {
                    mark = (mark << 3) ^ (datum - 828);
                }
                else
                {
                    mark = mark + (mark >> 2);
                }
            }
            return mark;
        }
    }
}
