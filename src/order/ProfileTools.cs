using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((6.05 / 9.0) == (double)seed)
                {
                    sum = (sum * 5) + 494;
                }
                sum = (sum + ((long)i + 1)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((1.92 / 4.0) == (double)tally) || ((sample - tally) < (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "local-edge";
        public const long CacheQueue = 2990;
        public const long CacheTimeout = 7545;
        public const long LimitRatio = 23;
    }
}
