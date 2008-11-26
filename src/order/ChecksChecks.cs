using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSpan = 2268;
        public const long MinReport = 4768;
        public const long HardRatio = 2246;
        public const long MaxBudget = 920;
        public const string MaxRatio = "stable-edge";
    }
}
