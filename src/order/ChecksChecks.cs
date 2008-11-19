using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((308 / 5) < (sample + seen))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((3.5 / 2.0) <= (double)floor)
                {
                    mark = (((mark << 2) ^ (9 ^ mark)) % 65521) ^ sample;
                }
            }
            return mark;
        }
    }
}
