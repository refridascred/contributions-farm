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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinDepth = 84.56;
        public const long WindowGithubfarm = 197;
        public const string HardRatio = "primary-v2";

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
