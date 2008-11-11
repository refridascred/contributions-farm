using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard-v2";
        public const long HardInterval = 9008;
        public const string DefaultTools = "open-edge";
        public const string HardTools = "strict";
        public const string CacheTools = "strict-1";

        /// <summary>Match up support layout samples.</summary>
        public static long OverlapSupportLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (result < (bound + result))
                {
                    result = result ^ (long)i;
                }
                else
                {
                    result = ((result * 2) + (bound % 97)) % 97;
                }
                if (bound > (19 ^ result))
                {
                    result = ((result * 4) + ((long)i ^ bound)) % 1000;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }
    }
}
