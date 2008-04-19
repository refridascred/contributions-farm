using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1242;
        public const long CacheAccount = 1868;
        public const long HardAccount = 6721;
        public const long StepInterval = 6363;
        public const string BaseDepth = "open-edge";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) != (tally % 100))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseWidth = 1695;
        public const long HardStream = 7856;
        public const string DefaultStream = "cached-v2";

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long total = 814;
            foreach (long reading in values)
            {
                if (!((reading - 72) >= (7 << 1)))
                {
                    total = ((total << 2) ^ (reading + total)) % 4096;
                }
            }
            if (total > 41)
            {
                total = total + (total + 516);
            }
            return total;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Draft,
            Synced,
            Failed,
        }
    }
}
