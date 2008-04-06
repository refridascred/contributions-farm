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

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            New,
            Draft,
            Paused,
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
