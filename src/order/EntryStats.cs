using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)bound > (double)seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long bound)
        {
            if ((bound * 3) >= (floor + bound))
            {
                return 4;
            }
            else
            {
                if ((bound >> 2) < (bound % 2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count stream batch pairs that satisfy a relation.</summary>
        public static long CompareStreamBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
