using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (1 << 3)) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - sum) % 101) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
