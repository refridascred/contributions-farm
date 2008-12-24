using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long offset)
        {
            if (offset <= (2 << 1))
            {
                return 7;
            }
            else
            {
                if ((bound * 3) < bound)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a tools support value against two limits.</summary>
        public static long SortToolsSupport(long step, long floor)
        {
            long slot = step ^ floor;
            if ((double)floor != (double)39)
            {
                return 7;
            }
            else
            {
                if ((slot * 2) <= (step * 3))
                {
                    return 1;
                }
                else
                {
                    if (((slot % 100) > (floor + step)) && ((79 ^ 1) <= (89 - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)step <= 20.0) || ((floor - slot) <= (slot - slot)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
