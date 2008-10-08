using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)75 <= (double)(long)i)
                {
                    mark = (mark + (step % 7)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((limit <= (limit >> 1)) || ((double)cell != (double)47)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long origin)
        {
            if ((double)target > (8.0 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((64 <= origin) && (origin < (origin - target)))
                {
                    return 8;
                }
                else
                {
                    if (origin < (3 * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
