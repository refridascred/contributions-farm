using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string StepSpan = "stable";
        public const long MaxEntry = 8410;
        public const string MaxCount = "stable-edge";

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 3) >= 589)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)923 != (double)cell)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
