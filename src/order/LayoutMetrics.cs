using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batches layout pair into a bucket.</summary>
        public static long RankBatchesLayout(long offset, long offset2)
        {
            long cur = offset + offset2;
            if (offset2 >= (cur - 2))
            {
                return 7;
            }
            else
            {
                if (((double)cur >= (double)66) && (((-1) ^ offset) == (offset + 28)))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 12) != (offset + offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset ^ cur) > (cur - cur)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - bound) < (hits - hits))
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

        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
