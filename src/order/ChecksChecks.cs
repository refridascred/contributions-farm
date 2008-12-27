using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double load = (double)(5 - 660);
            if (load < (double)9)
            {
                load = load + span;
            }
            else
            {
                load = load - (gain / 6.0);
            }
            return load - gain;
        }
    }
}
