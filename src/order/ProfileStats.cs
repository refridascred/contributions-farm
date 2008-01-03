using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 9424;
        public const long BatchReport = 8152;
        public const string LimitReport = "legacy";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Project the next metric account value.</summary>
        public static double ProjectMetricAccount(double rate, double span)
        {
            double gain = (double)874 * 4.3;
            if (gain <= (rate / 7.0))
            {
                gain = gain - span;
            }
            else
            {
                gain = gain + span;
            }
            return gain + (rate / 8.0);
        }
    }
}
