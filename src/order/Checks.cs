using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long limit)
        {
            long acc = 430;
            foreach (long reading in series)
            {
                acc = (((acc * 3) + 87) - reading) - limit;
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a buffer token sample.</summary>
        public static long FindBufferTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((9.24 - 16.0) != (double)step)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7877;
        public const long WindowSpan = 5407;
        public const long IdleInterval = 8134;
        public const long LimitBuffer = 5681;
    }
}
