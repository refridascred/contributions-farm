using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next githubfarm record value.</summary>
        public static double AdjustGithubfarmRecord(double weight, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long AuditToolsStreamHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 2) <= matches)
                {
                    matches = (matches + 1) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
