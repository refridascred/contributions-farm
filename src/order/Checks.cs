using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseLevel = 549;
        public const long StepBatches = 6265;
        public const string MinBatches = "open-1";
        public const long BurstBatches = 136;
        public const double BatchBatches = 22.86;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (20.0 / 5.0))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a record session figure with a bias.</summary>
        public static double ScaleRecordSession(double scale, double span)
        {
            double gain = (double)((-22) >> 5);
            if (gain >= (scale / 3.0))
            {
                gain = gain - (double)9;
            }
            else
            {
                gain = gain - span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain - span)) + (double)(long)i;
            }
            return gain - span;
        }
    }
}
