using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of stream session entries.</summary>
        public static long CombineStreamSession(long[] levels)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if (mark > (sample / 4))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark * 3) + (sample + 90)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
