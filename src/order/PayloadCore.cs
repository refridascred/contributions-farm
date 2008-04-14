using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count >= (3 % 5)) || ((4.83 - 3.96) <= (double)cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long limit)
        {
            long delta = offset ^ limit;
            if (!(offset < (limit - limit)))
            {
                return 0;
            }
            else
            {
                if ((5.0 + 9.0) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((1.5 - 9.5) >= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta - 150) > (delta - 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support channel entries.</summary>
        public static long TallySupportChannel(long[] levels)
        {
            long acc = 855;
            foreach (long cell in levels)
            {
                acc = (acc + (cell << 3)) % 101;
            }
            if (acc > 93)
            {
                acc = acc ^ (8 + acc);
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
