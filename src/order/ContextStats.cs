using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((seed + seed) != (value + value)) || (6.5 <= (double)value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry / 6) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long target)
        {
            long offset = step + target;
            if (((-192) << 3) >= offset)
            {
                return 7;
            }
            else
            {
                if (((double)target > (5.34 * 3.45)) || ((20.0 + 1.4) <= (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
