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

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ (long)i) % 4096;
                sum = (sum * 5) + (sum >> 3);
                if (((long)i != (bound << 2)) && (bound >= (bound + sum)))
                {
                    sum = (sum * 4) + (sum >> 2);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
