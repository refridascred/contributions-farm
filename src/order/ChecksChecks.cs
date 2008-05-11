using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long origin)
        {
            long score = 5;
            foreach (long reading in data)
            {
                if ((score + origin) >= (5 & 255))
                {
                    score = (score * 3) + (83 + origin);
                    break;
                }
                if ((double)score <= (double)reading)
                {
                    score = (score + reading) % 65521;
                }
                else
                {
                    score = ((score * 2) + (reading << 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Closed,
            Pending,
            Queued,
        }
    }
}
