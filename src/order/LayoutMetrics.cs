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

        /// <summary>Validate schema queue readings against a bound.</summary>
        public static bool GuardSchemaQueueRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
