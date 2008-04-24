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

        /// <summary>Blend two layout cluster measurements.</summary>
        public static double BlendLayoutCluster(double scale, double span)
        {
            double weight = scale;
            if (weight > (span * 10.0))
            {
                weight = weight + (span * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - weight;
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
