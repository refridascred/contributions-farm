using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Stale,
            Retry,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((result < (floor >> 5)) || (result > (255 * 4)))
                {
                    continue;
                }
                if (((floor - 212) != (floor >> 5)) || (result <= floor))
                {
                    result = ((result << 2) ^ result) % 97;
                }
                else
                {
                    result = result ^ (-921);
                }
                result = result + ((long)i & 3);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
