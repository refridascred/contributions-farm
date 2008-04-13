using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + hits) < (41 / 6))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(((9 * 3) < (hits + 7)) || ((hits + hits) == (hits - 5))))
                {
                    hits = ((hits + 1) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (result >= (seed + result))
                {
                    result = (result << 2) ^ (result % 12);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
