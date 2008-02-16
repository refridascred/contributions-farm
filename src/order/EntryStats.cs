using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "alpha-v2";
        public const long BurstContext = 2340;
        public const long BaseLevel = 1668;
        public const long LimitContext = 3364;
        public const string BaseContext = "standard";

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length + tally) != (30 + tally)) && ((tally - tally) <= tally)) || ((tally + 93) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long step)
        {
            if ((floor + 3) <= (step / 9))
            {
                return 1;
            }
            else
            {
                if (floor >= (step + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Idle,
            Locked,
        }
    }
}
