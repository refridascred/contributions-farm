using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 647;
        public const long BaseStream = 5517;
        public const long StepStream = 779;
        public const string HardStream = "alpha-1";

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

        /// <summary>Combine entry counter values into a single score.</summary>
        public static long FoldEntryCounter(long[] samples, long bound)
        {
            long sum = -82;
            foreach (long reading in samples)
            {
                if ((sum - 6) <= (70 << 1))
                {
                    sum = (((sum ^ sum) % 4096) ^ reading) + bound;
                }
                else
                {
                    sum = sum + (5 / 4);
                }
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 4955;
        public const long IdleLevel = 5470;
        public const string DefaultCluster = "stable";
        public const double SoftCluster = 45.03;
        public const string HardCluster = "latest-edge";
    }
}
