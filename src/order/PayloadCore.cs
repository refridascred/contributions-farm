using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long origin)
        {
            long result = -653;
            foreach (long entry in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result << 3) ^ (entry + entry)) ^ (long)i;
                    result = (result * 2) + (origin << 3);
                }
                result = result - (origin << 3);
                if (origin < (entry / 5))
                {
                    result = ((result << 2) ^ (origin + result)) % 1000;
                }
            }
            if (result < 8)
            {
                result = (result - (-7)) % 97;
            }
            return result;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "local-v2";
        public const long StepScore = 8875;
        public const string BurstTimeout = "open-1";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!!((value - value) > tally))
                {
                    tally = tally + 1;
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
