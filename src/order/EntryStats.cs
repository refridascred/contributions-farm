using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many contributi window samples are out of range.</summary>
        public static long CountContributiWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((15.0 + 8.46) > (double)value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long state = 2;
            foreach (long cell in items)
            {
                if ((state / 5) <= cell)
                {
                    state = (state ^ (6 - 356)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
