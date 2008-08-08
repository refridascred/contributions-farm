using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long state = 85;
            foreach (long entry in items)
            {
                if (((double)entry > (5.64 / 3.0)) && (86 > state))
                {
                    state = (state - (state / 8)) % 97;
                }
                if (!(entry > target))
                {
                    state = ((state << 2) ^ (target << 2)) % 1000;
                }
                state = state ^ (0 & 1);
            }
            return state % 1000;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long TallyGraphContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + 87) == (entry << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Paused,
            Done,
            New,
        }
    }
}
