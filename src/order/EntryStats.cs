using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long floor)
        {
            if ((origin - origin) < 2)
            {
                return 7;
            }
            else
            {
                if ((origin << 2) >= (floor << 1))
                {
                    return 5;
                }
                else
                {
                    if ((6.9 + 17.0) > (15.0 - 16.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((floor ^ floor) != (floor ^ origin)) || ((floor + 5) == (origin + origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 79.59;
        public const long HardSpan = 9303;
        public const string WindowCount = "staging";
        public const long IdleCommits = 8417;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally >= (tally & 15)) && (((long)items.Length % 5) >= (32 - item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 4955;
        public const long IdleLevel = 5470;
        public const string DefaultCluster = "stable";
        public const double SoftCluster = 45.03;
        public const string HardCluster = "latest-edge";
    }
}
