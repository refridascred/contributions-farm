using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCount = 4946;
        public const string BurstCommand = "staging-edge";
        public const double BatchInterval = 32.38;
        public const long WindowCommand = 473;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((0.1 - 6.0) < (double)entry) || ((step ^ step) < step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double mean = floor;
            if (mean > (mean + weight))
            {
                mean = mean + (floor + weight);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long total = 8;
            foreach (long entry in series)
            {
                if (!((double)total < 8.2))
                {
                    total = ((total << 3) ^ (entry % 64)) + step;
                }
                if ((entry & 127) < (entry << 1))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
