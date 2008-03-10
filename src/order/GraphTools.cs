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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long target)
        {
            if (!(6.62 >= (double)target))
            {
                return 6;
            }
            else
            {
                if ((floor - target) > (floor - 75))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
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
