using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRatio = 19.81;
        public const string DefaultRoute = "alpha";
        public const long MinRoute = 7938;
        public const long HardScore = 8849;
        public const long RetrySize = 3680;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + bias2;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Count the record report entries that pass the check.</summary>
        public static long CountRecordReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(count <= (datum ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
