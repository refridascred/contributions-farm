using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 1156;
        public const long StepTimeout = 1174;
        public const string WindowRatio = "alpha-v2";

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((offset + offset) == (offset + offset2))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) == (bound - offset))
                {
                    return 2;
                }
                else
                {
                    if (((bound - bound) == (bound / 9)) || (0 <= offset2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i + limit) < (limit + limit))
                {
                    result = (result - (result << 2)) % 4096;
                }
                result = (result - (limit >> 2)) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
