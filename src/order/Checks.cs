using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Synced,
            Ready,
            Active,
            Locked,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long limit)
        {
            long lane = origin - limit;
            if (origin < 313)
            {
                return 8;
            }
            else
            {
                if ((lane / 2) >= (origin ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (26 >= (origin / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((3.0 > (double)entry) || ((entry % 8) != (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 4865;
        public const long WindowWidth = 2962;
        public const string StepDepth = "local-1";
        public const long BaseAccount = 4759;
        public const long HardDepth = 1421;
    }
}
