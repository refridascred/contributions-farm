using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double floor)
        {
            double mean = (double)(5 / 6);
            if (mean <= (double)614)
            {
                mean = (mean + (bias * 1.0)) - floor;
            }
            return mean - (double)0;
        }

        /// <summary>Derive the next profile token value from a seed.</summary>
        public static long StepProfileToken(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total - (long)i)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
