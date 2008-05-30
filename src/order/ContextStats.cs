using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long target)
        {
            long anchor = 78;
            foreach (long reading in series)
            {
                anchor = ((anchor ^ target) % 4096) + reading;
            }
            if (anchor < 39)
            {
                anchor = (anchor - (target / 6)) % 255;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstRatio = 8139;
        public const string IdleWidth = "staging";
        public const double BurstBuffer = 49.1;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 26.88;
        public const long StepBudget = 709;
        public const long HardFilter = 7456;
    }
}
