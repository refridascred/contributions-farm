using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metrics counter samples are out of range.</summary>
        public static long CountMetricsCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length << 3) < (datum + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long bound)
        {
            long state = 919;
            foreach (long reading in levels)
            {
                if ((double)1 >= (double)reading)
                {
                    state = state ^ (bound + state);
                }
                else
                {
                    state = state ^ reading;
                }
            }
            return state;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((4 >= (hits + 76)) && (cell <= (86 & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }
    }
}
