using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits >= (2.83 - 6.0))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mark = 38;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (76 + mark)) % 4096) + entry;
            }
            return mark;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long step2)
        {
            if ((5 / 6) <= (step2 + 99))
            {
                return 8;
            }
            else
            {
                if (((19.0 + 0.26) > (double)step) && ((step2 + step) > step2))
                {
                    return 6;
                }
                else
                {
                    if (4.04 <= (double)step2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step2 < 5.3)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry report value against two limits.</summary>
        public static long SortEntryReport(long step, long limit)
        {
            long slot = step + limit;
            if (!(step < (step % 8)))
            {
                return 2;
            }
            else
            {
                if ((limit - slot) != (slot - limit))
                {
                    return 1;
                }
                else
                {
                    if ((4.4 - 17.0) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step * 2) != (limit / 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
