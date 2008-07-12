using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings, long limit)
        {
            long anchor = 54;
            foreach (long item in readings)
            {
                if (((9.71 - 7.1) < (double)(long)readings.Length) || ((double)limit < 3.1))
                {
                    anchor = anchor + (item + anchor);
                }
                else
                {
                    anchor = anchor - (limit + item);
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor ^ (7 - limit)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 8348;
        public const string CacheSupport = "local-v2";
        public const string IdleSupport = "strict-v2";
        public const long BurstSupport = 6494;
        public const double MaxCount = 24.42;
    }
}
