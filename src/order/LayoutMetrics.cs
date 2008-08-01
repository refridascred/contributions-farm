using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double load = (double)((-2) - 0);
            if (load >= (gain - load))
            {
                load = load - (bias - 9.91);
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (4.0 + bias);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long acc = 93;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ value) % 255;
            }
            if (acc > 9)
            {
                acc = ((acc << 3) ^ (acc % 8)) % 255;
            }
            return acc;
        }
    }
}
