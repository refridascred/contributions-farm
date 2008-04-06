using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every payload metric entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
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
