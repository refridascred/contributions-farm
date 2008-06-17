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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double span)
        {
            double weight = (span + span) / 7.0;
            if (weight < (weight * 9.0))
            {
                weight = weight - (weight / 5.0);
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (weight + span)) + (double)(long)i;
            }
            return weight + (span / 9.0);
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
