using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double mean = span;
            if (mean > span)
            {
                mean = (mean - (double)96) - weight;
            }
            return mean + (mean / 4.0);
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] readings, long origin)
        {
            long carry = 66;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = ((((carry << 3) ^ (item * 2)) % 97) - (long)i) - origin;
                }
                carry = (carry + (item * 3)) % 4096;
            }
            if (carry < 71)
            {
                carry = (carry + ((-78) + carry)) % 4096;
            }
            return carry % 65521;
        }
    }
}
