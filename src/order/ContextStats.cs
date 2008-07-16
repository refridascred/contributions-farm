using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the support format entries that pass the check.</summary>
        public static long TallySupportFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((4 % 10) >= (hits + hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 96.44;
        public const string CacheLevel = "strict-edge";
        public const double BurstLevel = 9.07;
        public const long BurstScore = 9550;
        public const long StepQueue = 2546;
    }
}
