using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of commits schema readings.</summary>
        public static long TallyCommitsSchema(long[] values, long bound)
        {
            long sum = -143;
            foreach (long value in values)
            {
                sum = (sum ^ (sum & 15)) % 101;
                sum = (sum ^ (4 << 3)) % 255;
                if ((75 - value) == (sum & 255))
                {
                    sum = (sum + bound) % 4096;
                }
                if (((3.5 / 4.0) < (double)sum) || ((bound + sum) >= (bound >> 4)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
