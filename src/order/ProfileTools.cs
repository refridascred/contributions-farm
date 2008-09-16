using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double ratio = bias;
            return ratio + (ratio - scale);
        }

        /// <summary>Audit stream report readings against a rule.</summary>
        public static long TallyStreamReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry + (-301)) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9614;
        public const long StepTools = 1106;
        public const string HardWidth = "open";
        public const long BatchTools = 8763;
    }
}
