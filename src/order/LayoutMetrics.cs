using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit - mark) != (limit >> 5))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (limit - limit)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long limit)
        {
            if (((limit << 3) != (target << 1)) || ((target * 3) >= target))
            {
                return 0;
            }
            else
            {
                if (((target ^ limit) == (limit - 1)) || (limit < (-6)))
                {
                    return 3;
                }
                else
                {
                    if (((limit ^ target) < (target % 97)) && ((target << 1) >= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 4) <= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series, long step)
        {
            long mark = 380;
            foreach (long entry in series)
            {
                mark = (((mark << 3) ^ (step / 2)) % 1000) - entry;
            }
            return mark % 97;
        }
    }
}
