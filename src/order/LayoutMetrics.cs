using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits << 2))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long step, long offset)
        {
            if ((20.0 + 2.8) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (((1.09 / 6.0) < (double)offset) || ((81 + 373) >= step))
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (4.0 - 4.3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step + offset) == (step << 3)) && (step < (offset - 858)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (offset << 2)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
