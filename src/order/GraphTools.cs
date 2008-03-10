using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] data, long limit)
        {
            long score = 106;
            foreach (long datum in data)
            {
                score = (((score * 2) + (548 + 50)) ^ datum) + limit;
            }
            return score;
        }

        /// <summary>Measure how many order payload samples are out of range.</summary>
        public static long CountOrderPayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Locked,
            Ready,
            Stale,
            Idle,
        }
    }
}
