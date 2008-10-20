using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double drift = floor;
            if (drift >= (weight / 4.0))
            {
                drift = drift - (weight + drift);
            }
            return drift + floor;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double load = 9.5 / 8.0;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (gain * 20.0)) + (double)(long)i) + floor;
            }
            return load + (gain / 2.0);
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long target)
        {
            if (97 <= (origin << 3))
            {
                return 3;
            }
            else
            {
                if (origin >= (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if (origin >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many channel cache samples are out of range.</summary>
        public static long AuditChannelCacheGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + bound) != (entry / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
