using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long result = 994;
            foreach (long reading in data)
            {
                if (!((limit + reading) <= limit))
                {
                    result = result + (reading % 16);
                }
            }
            if (result < 83)
            {
                result = result ^ (limit ^ (long)data.Length);
            }
            return result % 4096;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Project the next already metric value.</summary>
        public static double ProjectAlreadyMetric(double weight, double floor)
        {
            double scale = (double)3 * 4.1;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (floor + floor)) + (double)(long)i) - weight;
            }
            return scale - (scale - floor);
        }
    }
}
