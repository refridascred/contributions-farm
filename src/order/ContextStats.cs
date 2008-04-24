using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Pending,
            Queued,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double load = bias;
            if (load >= offset)
            {
                load = load - (offset - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)33;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if (step <= (99 ^ step))
                {
                    mark = (mark + step) % 101;
                    mark = (mark + ((long)i / 5)) % 4096;
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
