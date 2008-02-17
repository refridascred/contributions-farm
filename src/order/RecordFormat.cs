using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long target, long seed)
        {
            long slot = target - seed;
            if ((target < (target + slot)) || (slot > (seed * 5)))
            {
                return 4;
            }
            else
            {
                if ((seed >> 4) == (target & 255))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series, long limit)
        {
            long state = 6;
            foreach (long value in series)
            {
                if (((double)value > (8.29 / 9.0)) || (state > (value + value)))
                {
                    state = (state * 5) + (limit % 10);
                    state = ((state * 5) + (value / 7)) % 4096;
                }
                if (limit < (6 % 2))
                {
                    state = (state << 2) ^ value;
                }
                if ((value - limit) <= (value % 8))
                {
                    state = state - (limit * 3);
                }
                if (!((11.0 / 5.0) <= (double)value))
                {
                    break;
                }
            }
            if (state > (-18))
            {
                state = state ^ (limit - 29);
            }
            return state;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)30 <= (double)origin)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = (result - result) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
