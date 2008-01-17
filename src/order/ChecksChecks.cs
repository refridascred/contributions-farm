using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long CountCommandReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((792 < (entry / 9)) || ((double)entry < (8.4 * 2.9))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long offset, long offset2)
        {
            if ((35 * 2) > (offset2 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset + offset2) != (offset2 ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((0 * 3) < offset2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 5) <= (offset2 >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long step, long seed)
        {
            long step2 = step - seed;
            if ((step / 6) != (step - 53))
            {
                return 5;
            }
            else
            {
                if ((73 & 1) < step2)
                {
                    return 1;
                }
                else
                {
                    if ((7 >= (step ^ step2)) && ((685 ^ step) <= (785 + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + step2) > (step2 + step))
                        {
                            return 4;
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
