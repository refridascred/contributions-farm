using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate tools batch samples.</summary>
        public static long WeighToolsBatch(long[] series)
        {
            long anchor = -577;
            foreach (long cell in series)
            {
                if ((double)cell != (9.86 + 5.44))
                {
                    anchor = (anchor << 3) ^ 469;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a token metrics sample.</summary>
        public static long LookupTokenMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ (sum + limit)) % 1000;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitInterval = 26.9;
        public const double MinCache = 27.21;
        public const long BatchCache = 139;
        public const long SoftCache = 6487;
    }
}
