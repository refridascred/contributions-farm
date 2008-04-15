using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long seed, long origin)
        {
            if (((double)seed != (double)813) && ((71 - 4) < (seed - (-807))))
            {
                return 2;
            }
            else
            {
                if ((205 + origin) < (origin / 2))
                {
                    return 8;
                }
                else
                {
                    if (!((double)seed < 17.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((20.0 + 9.0) > (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                acc = (acc ^ (floor + 39)) - value;
            }
            return acc;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score + floor);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (origin + origin)) % 101;
                if ((origin < mark) || ((mark + origin) == (mark - (long)i)))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
