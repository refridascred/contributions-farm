using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + 0) >= (reading * 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 31.24;
        public const long WindowFarm = 2135;
        public const long CacheFarm = 3506;

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double bias2)
        {
            double rate = bias2 * 4.3;
            if (rate >= bias2)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (bias * 5.0);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Done,
            Stale,
            Draft,
            Locked,
        }
    }
}
