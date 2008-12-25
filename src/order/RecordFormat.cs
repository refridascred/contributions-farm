using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stats counter entries that pass the check.</summary>
        public static long TallyStatsCounterMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= 2.4)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a window account value against two limits.</summary>
        public static long RankWindowAccount(long target, long bound)
        {
            long delta = target + bound;
            if (0.51 >= (double)target)
            {
                return 8;
            }
            else
            {
                if (4.5 < (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((962 >= (delta * 4)) && ((93 * 3) != (bound % 60)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
