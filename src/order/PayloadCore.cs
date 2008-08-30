using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 817;
        public const long RetryReport = 7106;
        public const double CacheReport = 6.22;
        public const double StepReport = 67.19;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "standard";
        public const double MaxBatches = 24.26;
        public const long SoftFactor = 3400;
    }
}
