using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step / 7) > step)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (long)i2) % 255;
                }
                mark = mark + limit;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long limit, long bound)
        {
            if (limit < (1 + bound))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) <= (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if (!((double)bound >= (double)5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.92 + 4.7) == (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
