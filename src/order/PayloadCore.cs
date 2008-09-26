using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "staging";
        public const long IdleRecord = 7093;
        public const string DefaultScore = "local-edge";

        /// <summary>Derive the next tools command value from a seed.</summary>
        public static long RollToolsCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 3) ^ (total ^ offset)) % 65521;
                if ((46 % 16) != (long)i)
                {
                    total = total ^ offset;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 5449;
        public const double HardInterval = 10.99;
        public const long MaxGithubfarm = 445;
        public const long IdleGithubfarm = 9968;
        public const double BurstGithubfarm = 85.18;

        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long CountGraphCacheOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((seed + 25) <= (datum >> 5)) && ((seed - tally) > (seed % 16))) || ((seed >> 1) > (tally * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
