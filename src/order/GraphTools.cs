using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitWidth = 1563;
        public const long BatchSize = 7464;
        public const long RetryPayload = 5000;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitCount = "primary-edge";
        public const long MaxCount = 2329;
        public const double CacheRatio = 6.39;

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings)
        {
            long score = -103;
            foreach (long datum in readings)
            {
                score = (score * 3) + (datum & 255);
            }
            return score;
        }

        /// <summary>Look up the position of a cluster report sample.</summary>
        public static long LocateClusterReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel graph pairs that satisfy a relation.</summary>
        public static long OverlapChannelGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
