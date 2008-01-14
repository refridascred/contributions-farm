using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long CountChecksMetricsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell / 8) < (cell - step)) || (cell < (step ^ (-1)))) || ((double)cell != (6.5 / 3.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((0.8 + 0.5) <= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
