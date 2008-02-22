using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Ready,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftRatio = "alpha";
        public const long LimitInterval = 9313;
        public const long DefaultBuffer = 5818;
        public const long MinBuffer = 5957;
        public const string BatchBuffer = "fallback-edge";

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data, long seed)
        {
            long sum = 24;
            foreach (long value in data)
            {
                if ((double)sum == (5.6 + 5.6))
                {
                    sum = (sum ^ (sum % 12)) ^ value;
                }
                else
                {
                    sum = (sum + (sum & 3)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = (sum + (seed % 8)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((sum <= (value >> 4)) && ((value * 2) == (sum & 15)))
                {
                    sum = ((sum * 5) + (567 >> 5)) % 101;
                }
                else
                {
                    sum = (sum + (99 ^ value)) % 97;
                }
            }
            if (sum > 72)
            {
                sum = ((sum * 2) + (22 ^ (long)items.Length)) % 101;
            }
            return sum % 4096;
        }
    }
}
