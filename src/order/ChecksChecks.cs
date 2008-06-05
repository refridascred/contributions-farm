using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "cached";
        public const long BaseRecord = 7310;
        public const string StepRecord = "staging-edge";
        public const long CacheWidth = 9421;
    }
}
