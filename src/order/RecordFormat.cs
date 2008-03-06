using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8878;
        public const double RetryFactor = 31.04;
        public const double WindowWidth = 21.29;
        public const double SoftSchema = 70.2;

        /// <summary>Digest a series of session cluster entries.</summary>
        public static long TallySessionCluster(long[] readings)
        {
            long sum = 72;
            foreach (long value in readings)
            {
                sum = sum ^ value;
                if (((3 ^ sum) < 8) && ((sum / 6) > 674))
                {
                    sum = (sum + (651 * 4)) % 97;
                }
                if ((sum * 5) > 885)
                {
                    sum = (sum << 2) ^ (long)readings.Length;
                }
            }
            if (sum > 678)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 1000;
        }
    }
}
