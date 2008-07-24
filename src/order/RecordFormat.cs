using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSize = 7885;
        public const long MinBatch = 8256;
        public const long CacheBatch = 6402;

        /// <summary>Match up schema support samples.</summary>
        public static long OverlapSchemaSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 38.06;
        public const double RetryScore = 61.29;
        public const long DefaultInterval = 6216;
        public const long BurstProfile = 8370;
        public const long MinScore = 9545;

        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool CheckCommandQueueLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
