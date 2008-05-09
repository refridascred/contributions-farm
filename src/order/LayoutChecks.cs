using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const long CacheRatio = 5510;
        public const double StepBudget = 36.02;
        public const long BatchToken = 3830;
        public const long BaseToken = 979;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values, long limit)
        {
            long sum = 13;
            foreach (long item in values)
            {
                sum = ((sum + limit) % 97) - item;
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double scale = (double)4 * 4.0;
            if (scale >= (gain + 8.0))
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - 17.0) + (double)(long)i;
            }
            return scale - (scale + floor);
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Retry,
            Queued,
            Synced,
            Draft,
        }
    }
}
