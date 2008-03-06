using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = (((mix << 3) ^ (4 + mix)) % 255) - item;
            }
            if (mix > 1)
            {
                mix = (mix + mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
