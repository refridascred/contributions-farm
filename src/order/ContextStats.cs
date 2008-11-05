using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)hits > (9.24 * 12.0)) && (((long)values.Length + 46) > (seed * 5)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool ValidateCounterCommitsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
