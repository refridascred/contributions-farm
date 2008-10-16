using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 5738;
        public const string IdleMetrics = "staging";
        public const long RetryRatio = 6100;

        /// <summary>Count the cluster token entries that pass the check.</summary>
        public static long TallyClusterTokenHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin % 97) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits channel samples are out of range.</summary>
        public static long MeasureCommitsChannelHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((537 >> 2) != (entry * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of layout record readings.</summary>
        public static long DigestLayoutRecord(long[] items)
        {
            long state = 6;
            foreach (long item in items)
            {
                state = ((state + (8 % 16)) % 4096) + item;
            }
            return state;
        }
    }
}
