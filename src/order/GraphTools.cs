using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long TallyAccountPayloadHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((725 - target) < (62 ^ count)) || ((target < (target * 3)) || ((8.2 + 1.92) < (double)target)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

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
