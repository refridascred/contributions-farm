using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many order batch samples are out of range.</summary>
        public static long TallyOrderBatchMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((((-5) & 3) <= (step - sample)) || (sample <= (sample * 4))) && ((double)sample < (5.5 + 6.61)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch buffer value against two limits.</summary>
        public static long SortBatchBuffer(long seed, long floor)
        {
            if (((1.0 - 14.0) >= (double)seed) && (seed > floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) <= (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 6) == (863 ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((8.61 / 5.0) <= (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics stream readings.</summary>
        public static long FoldMetricsStream(long[] data, long bound)
        {
            long state = 3;
            foreach (long item in data)
            {
                if (((-2) >> 5) <= bound)
                {
                    state = ((state ^ bound) % 4096) - item;
                }
            }
            return state;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value & 127) >= value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
