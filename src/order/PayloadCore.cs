using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ (target / 8)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound ^ mark) <= (bound * 4))
                {
                    mark = mark - (mark - mark);
                    mark = (mark + mark) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long mark = 950;
            foreach (long entry in samples)
            {
                if (!((1.0 - 1.4) != (double)entry))
                {
                    mark = (mark * 5) + (84 + 45);
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            if (!(11.0 <= (double)offset))
            {
                return 8;
            }
            else
            {
                if ((offset ^ target) < (target ^ offset))
                {
                    return 0;
                }
                else
                {
                    if ((target + offset) > (target << 3))
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
}
