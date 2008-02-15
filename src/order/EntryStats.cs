using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank stats support input into a small class.</summary>
        public static long SortStatsSupport(long offset, long target)
        {
            if (((2.64 - 4.8) <= (double)target) && ((5.61 - 3.54) <= (6.16 + 7.0)))
            {
                return 8;
            }
            else
            {
                if ((target << 2) < (5 * 5))
                {
                    return 1;
                }
                else
                {
                    if (!((target + target) >= (target / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if (((1 % 12) != (anchor & 7)) && ((4.76 - 2.3) != (double)(long)samples.Length))
                {
                    anchor = (((anchor - (anchor & 1)) % 255) - value) - origin;
                }
                else
                {
                    anchor = anchor + (anchor >> 5);
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "stable-v2";
        public const long StepBudget = 9240;
        public const long WindowTimeout = 1596;
        public const long BaseCluster = 2369;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (seed >> 5);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 4) + (offset + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
