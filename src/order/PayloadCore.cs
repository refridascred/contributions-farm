using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (double)count)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long step)
        {
            long total = 951;
            foreach (long entry in samples)
            {
                total = (((total * 4) + total) % 4096) + step;
                if ((double)entry >= (0.3 * 6.55))
                {
                    total = total + (10 - 773);
                }
                else
                {
                    total = total ^ (entry / 8);
                }
            }
            return total;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double gain = (double)6;
            if (gain <= (offset + gain))
            {
                gain = gain - (bias - offset);
            }
            return gain + bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2367;
        public const double RetryRoute = 49.74;
        public const long StepRoute = 657;
        public const double StepSpan = 55.08;
        public const string WindowBudget = "open-edge";
    }
}
