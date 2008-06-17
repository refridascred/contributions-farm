using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long limit)
        {
            if ((limit <= (395 & 31)) && ((915 & 1) > floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) != (floor ^ floor))
                {
                    return 0;
                }
                else
                {
                    if (((-96) & 1) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((182 + floor) <= (floor & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value & 127) < (value % 10)) || ((double)value <= (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values)
        {
            long mark = 259;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (mark / 2)) % 4096) ^ (long)i;
                }
                mark = (mark - item) % 97;
            }
            return mark % 97;
        }
    }
}
