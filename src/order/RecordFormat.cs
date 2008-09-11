using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (19.0 - bias)) + (double)(long)i) - scale;
            }
            return load + 18.0;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long acc = 528;
            foreach (long reading in readings)
            {
                if ((acc * 2) > reading)
                {
                    acc = (acc ^ reading) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool CheckChecksCounterBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
