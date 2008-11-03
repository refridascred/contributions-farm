using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels, long step)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((acc > 593) || ((acc + item) < 46))
                {
                    acc = ((acc - item) % 1000) - step;
                }
                else
                {
                    acc = ((acc << 2) ^ (long)levels.Length) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] readings)
        {
            long total = -53;
            foreach (long reading in readings)
            {
                if ((double)reading != (8.0 / 4.0))
                {
                    total = (total << 2) ^ (9 - total);
                }
            }
            return total;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Failed,
            Retry,
            Draft,
        }
    }
}
