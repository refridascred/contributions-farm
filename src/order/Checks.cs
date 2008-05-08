using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen < (datum * 3)) || ((double)datum < 8.6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 44.74;
        public const double MaxGithubfarm = 1.48;
        public const long WindowSize = 4943;
        public const long SoftRatio = 1567;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((68 + bound) == (total * 3)) && (total >= (39 << 3)))
                {
                    total = ((total * 2) + bound) % 97;
                    total = total + (total >> 2);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            New,
            Retry,
        }
    }
}
