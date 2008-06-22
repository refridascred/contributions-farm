using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two metrics batch measurements.</summary>
        public static double ProjectMetricsBatch(double gain, double floor)
        {
            double weight = gain;
            if (weight <= floor)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight * 3.7)) - (double)(long)i;
            }
            return weight - 4.82;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long limit)
        {
            if (((limit & 7) != (5 & 255)) && (limit > step))
            {
                return 8;
            }
            else
            {
                if ((step * 4) < limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit % 24) == (step + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Pending,
            Active,
            Retry,
        }
    }
}
