using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long RollBatchesSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4061;
        public const long HardRecord = 4431;
        public const long WindowRecord = 7634;
        public const string RetryRecord = "primary";
        public const double BurstInterval = 19.59;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long origin)
        {
            long result = 820;
            foreach (long sample in values)
            {
                result = ((result ^ (result & 63)) % 1000) + sample;
                result = result + (origin - result);
            }
            return result;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
