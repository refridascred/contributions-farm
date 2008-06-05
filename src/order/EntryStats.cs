using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 9996;
        public const long MaxRoute = 8377;
        public const long BurstWidth = 9467;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already command value against two limits.</summary>
        public static long BucketAlreadyCommand(long bound, long origin)
        {
            if ((double)origin <= (1.8 - 4.4))
            {
                return 6;
            }
            else
            {
                if ((7 / 5) <= (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if ((bound <= (origin * 2)) || ((bound + 493) <= (bound & 127)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin < (1.9 - 6.99))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long limit)
        {
            long prev = target ^ limit;
            if ((limit << 3) != (prev + limit))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) <= (prev << 1))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
