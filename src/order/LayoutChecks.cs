using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 6182;
        public const double CacheCount = 3.77;
        public const long HardMetrics = 4158;
        public const long SoftMetrics = 6659;
        public const double BurstMetrics = 21.79;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1960;
        public const long LimitCount = 71;
        public const double BaseCommits = 22.57;
        public const long BurstWidth = 2477;

        /// <summary>Classify a schema metric pair into a bucket.</summary>
        public static long ClassifySchemaMetric(long limit, long origin)
        {
            if ((limit + limit) < limit)
            {
                return 0;
            }
            else
            {
                if ((limit + origin) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((599 + limit) < (origin % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin == (18.0 - 6.94))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
