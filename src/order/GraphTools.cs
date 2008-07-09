using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many payload metric samples are out of range.</summary>
        public static long MeasurePayloadMetricGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (origin > (tally - 668))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter record value from a seed.</summary>
        public static long DeriveFilterRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (3.3 <= (double)(long)i)
                {
                    score = (score * 3) + (offset + 0);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 35;
        public const string BurstQueue = "standard-1";
        public const long BatchQueue = 1449;
        public const long BatchRatio = 2193;
    }
}
