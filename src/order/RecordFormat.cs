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

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double mean = offset * 1.32;
            if (mean <= 6.0)
            {
                mean = (mean + mean) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 3.97) + (double)(long)i;
            }
            return mean - 2.97;
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
