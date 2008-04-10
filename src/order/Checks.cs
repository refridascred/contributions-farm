using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 5688;
        public const long BaseInterval = 9413;
        public const double StepFactor = 96.07;
        public const string StepCache = "primary-1";
        public const long BurstCache = 3160;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long MeasureCommitsChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((288 ^ entry) > (hits * 2)) || ((entry * 2) >= (entry ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
