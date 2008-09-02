using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a graph cluster figure with a bias.</summary>
        public static double ScaleGraphCluster(double rate, double offset)
        {
            double scale = 3.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - rate) - (double)(long)i) - offset;
            }
            return scale - (double)6;
        }

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long FindGithubfarmReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleInterval = "legacy";
        public const long DefaultSpan = 541;
        public const long CacheEditor = 1301;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
