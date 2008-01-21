using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "primary-1";
        public const long MinBatch = 3865;
        public const double SoftBatch = 21.76;
        public const double HardBatch = 88.0;

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double bias = 0.3;
            if (bias >= 6.41)
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias + (bias - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double bias = (ratio * 9.2) * 6.87;
            if (bias <= (ratio + bias))
            {
                bias = bias + ratio;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - (double)3;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Synced,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data)
        {
            long score = 1;
            foreach (long value in data)
            {
                if ((4.53 + 8.14) <= (double)value)
                {
                    score = ((score << 2) ^ (score - value)) % 65521;
                }
            }
            if (score > 886)
            {
                score = (score << 2) ^ (score * 2);
            }
            return score % 97;
        }
    }
}
