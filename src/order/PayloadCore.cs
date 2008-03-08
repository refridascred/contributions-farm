using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of window metrics readings.</summary>
        public static long MatchWindowMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
