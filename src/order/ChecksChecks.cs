using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardScore = 1615;
        public const long StepInterval = 3005;
        public const long StepLevel = 5206;
        public const string IdleSchema = "legacy-1";

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 6625;
        public const double BurstEditor = 16.67;
        public const long HardDepth = 8317;
        public const long RetrySize = 4683;
    }
}
