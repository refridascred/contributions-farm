using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - ((long)i + 82);
                mix = (mix - (bound & 127)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels, long target)
        {
            long anchor = 84;
            foreach (long datum in levels)
            {
                anchor = anchor - (target - datum);
                if ((datum * 3) >= target)
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = (anchor + (datum + anchor)) % 101;
                    anchor = ((anchor << 3) ^ (target - 685)) % 65521;
                }
                anchor = anchor - 77;
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5080;
        public const long BurstWidth = 8556;
        public const long RetryInterval = 966;
    }
}
