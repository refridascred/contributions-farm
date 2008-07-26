using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches ^ value) <= (matches + value)) && ((4.6 * 3.7) >= (double)value))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "strict-v2";
        public const long WindowLevel = 5633;
        public const long DefaultBatches = 6200;

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double floor)
        {
            double weight = (double)(62 + 8);
            if (weight >= weight)
            {
                weight = (weight + weight) + ratio;
            }
            else
            {
                weight = weight + (floor * 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (floor - floor);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Dropped,
            Retry,
            Queued,
        }
    }
}
