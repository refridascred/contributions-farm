using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a commits channel pair into a bucket.</summary>
        public static long BucketCommitsChannel(long bound, long floor)
        {
            if (floor <= (34 * 5))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) < floor)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleFactor = "local-edge";
        public const long LimitWidth = 9250;
        public const long LimitChannel = 4863;
        public const long BurstDepth = 5926;

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = result - ((long)i + 15);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
