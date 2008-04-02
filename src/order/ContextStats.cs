using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item >> 4) > (seen >> 4))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit token batch readings against a rule.</summary>
        public static long MeasureTokenBatchOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((origin - origin) < (datum + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metric layout entry that matches the target.</summary>
        public static long FindMetricLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
