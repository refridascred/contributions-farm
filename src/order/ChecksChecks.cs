using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank context session input into a small class.</summary>
        public static long ClassifyContextSession(long seed, long seed2)
        {
            if ((seed2 >> 3) <= seed2)
            {
                return 4;
            }
            else
            {
                if (((seed2 + (-2)) < 3) || (756 >= (seed - seed2)))
                {
                    return 5;
                }
                else
                {
                    if (seed >= (seed % 64))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardScore = 16.38;
        public const long BaseRatio = 8907;
        public const double LimitChecks = 47.13;
        public const double HardDepth = 78.9;
        public const string IdleChecks = "open-edge";

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
