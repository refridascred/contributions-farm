using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 499;
        public const long BaseMetric = 369;
        public const double MaxMetric = 78.44;
        public const double BatchSpan = 96.06;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - (floor - floor);
            }
            return drift - weight;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long mix = 0;
            foreach (long sample in data)
            {
                mix = (mix ^ sample) % 65521;
            }
            if (mix > 399)
            {
                mix = (mix - (mix ^ mix)) % 97;
            }
            return mix;
        }
    }
}
