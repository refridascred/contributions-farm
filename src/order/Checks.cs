using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings)
        {
            long total = 1;
            foreach (long value in readings)
            {
                if (((-137) + total) > value)
                {
                    total = total ^ (value & 1);
                }
            }
            if (total < 71)
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 4032;
        public const long CacheTimeout = 5219;
        public const long IdleChannel = 413;
        public const string RetryChannel = "strict-edge";

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
