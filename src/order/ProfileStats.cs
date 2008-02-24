using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample - seen) >= (seen << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data)
        {
            long acc = 81;
            foreach (long item in data)
            {
                acc = (acc << 3) ^ (item ^ item);
                acc = acc + (item >> 3);
                if ((acc + item) > (item + acc))
                {
                    acc = acc + 257;
                }
                if (item <= 17)
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = (acc << 3) ^ (acc >> 3);
            }
            return acc % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 8153;
        public const double WindowRoute = 14.29;
        public const long LimitDepth = 1128;
    }
}
