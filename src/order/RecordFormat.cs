using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a checks channel counter forward.</summary>
        public static long DeriveChecksChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long RollBatchesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
