using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support token series from a seed.</summary>
        public static long IterateSupportToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)offset >= 1.53))
                {
                    sum = sum + (91 ^ sum);
                    sum = sum + (offset >> 2);
                }
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Draft,
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "stable-v2";
        public const long DefaultBudget = 7912;
        public const string WindowCommits = "strict-1";
        public const long DefaultSpan = 4368;
        public const string DefaultLevel = "standard";

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
