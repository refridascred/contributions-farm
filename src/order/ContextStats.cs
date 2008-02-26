using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long seed, long bound)
        {
            if ((51 >> 4) < seed)
            {
                return 7;
            }
            else
            {
                if (((seed - bound) > 697) && ((bound << 2) >= bound))
                {
                    return 8;
                }
                else
                {
                    if ((seed + bound) == (bound << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed + (-695)) <= (seed << 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits & 127) < (step / 3))
                {
                    hits = (hits + 1) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
