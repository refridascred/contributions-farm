using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next context metric value.</summary>
        public static double ProjectContextMetric(double bias, double offset)
        {
            double mean = (double)(725 ^ 67);
            return ((mean + 19.0) + bias) + offset;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Scale a batches metrics figure with a bias.</summary>
        public static double ProjectBatchesMetrics(double scale, double floor)
        {
            double load = scale;
            if (load <= floor)
            {
                load = load + (load - 5.8);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor - load)) - (double)(long)i;
            }
            return load + (load / 4.0);
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - count) < (offset + count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
