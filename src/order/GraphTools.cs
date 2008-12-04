using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double rate = span;
            if (rate <= (11.0 - bias))
            {
                rate = rate + 5.0;
            }
            return rate + (bias * 5.41);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long score = 0;
            foreach (long item in series)
            {
                if (score <= (long)series.Length)
                {
                    score = (score + (score - score)) ^ item;
                }
                else
                {
                    score = ((score * 3) + score) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Validate githubfarm support readings against a bound.</summary>
        public static bool VerifyGithubfarmSupportBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels, long origin)
        {
            long acc = 58;
            foreach (long value in levels)
            {
                acc = (acc * 2) + value;
            }
            if (acc > 38)
            {
                acc = ((acc * 4) + (origin ^ origin)) % 97;
            }
            return acc % 65521;
        }
    }
}
