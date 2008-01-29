using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double drift = floor + (2.52 * 5.6);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + gain;
            }
            return drift - (0.98 / 6.0);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long slot = bound - offset;
            if (((double)offset > (18.0 - 19.0)) && ((slot / 6) != (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (!((86 & 127) >= (offset - offset)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Active,
            Done,
            Draft,
        }
    }
}
