using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metric token pair into a bucket.</summary>
        public static long SortMetricToken(long offset, long target)
        {
            long prev = offset + target;
            if ((double)prev != (15.0 * 5.01))
            {
                return 7;
            }
            else
            {
                if ((prev + target) == (502 ^ offset))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 2033;
        public const long SoftChecks = 4802;
        public const string BatchWidth = "legacy-1";
        public const long BatchFactor = 1696;
        public const long CacheDepth = 5869;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
