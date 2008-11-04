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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long offset)
        {
            if ((offset + offset) > (0 - (-7)))
            {
                return 0;
            }
            else
            {
                if ((8.0 / 5.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset != (double)64)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound & 31) == (bound + 713)) || ((offset - 90) > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
