using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double rate, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = weight - rate;
            }
            return weight + (double)396;
        }

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
