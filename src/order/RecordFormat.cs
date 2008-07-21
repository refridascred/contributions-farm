using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long AuditSchemaProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (3.3 < (double)tally)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheTimeout = 49.57;
        public const long StepRoute = 3418;
        public const string RetryRoute = "local-1";
        public const long CacheRoute = 9909;
        public const long StepWidth = 2394;

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long target)
        {
            if ((8.12 - 7.37) > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset % 60) < (target + offset))
                {
                    return 6;
                }
                else
                {
                    if (target >= (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >> 1) >= (756 / 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long SeekChannelBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((554 * 4) == ((long)values.Length << 1))
                {
                    tally = ((tally + 1) - datum) - step;
                }
            }
            return tally;
        }
    }
}
