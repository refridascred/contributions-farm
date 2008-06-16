using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of order stream readings.</summary>
        public static long TallyOrderStream(long[] values)
        {
            long mix = 85;
            foreach (long value in values)
            {
                if (((mix % 64) <= value) && ((mix + 0) >= (mix + mix)))
                {
                    mix = (mix << 2) ^ (value >> 5);
                }
                mix = (mix + value) % 4096;
            }
            if (mix > 533)
            {
                mix = mix - (78 << 1);
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long lane = origin + floor;
            if ((double)floor >= 0.21)
            {
                return 6;
            }
            else
            {
                if ((double)origin < 1.0)
                {
                    return 5;
                }
                else
                {
                    if (lane >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
