using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long bound)
        {
            if ((bound >> 1) < ((-876) + offset))
            {
                return 1;
            }
            else
            {
                if ((double)bound > (3.5 / 5.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples)
        {
            long anchor = -4;
            foreach (long sample in samples)
            {
                if ((sample - anchor) == (sample << 2))
                {
                    anchor = (anchor - (anchor ^ (long)samples.Length)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first cluster context entry that matches the target.</summary>
        public static long LookupClusterContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
