using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double offset)
        {
            double scale = (double)(-25) * 5.9;
            if (scale >= offset)
            {
                scale = (scale + 8.0) + rate;
            }
            return scale - (double)(-638);
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double gain, double span)
        {
            double drift = span - (double)3;
            return (drift - drift) + gain;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long seed)
        {
            long step = limit + seed;
            if (((limit + limit) > (limit + seed)) || (limit <= seed))
            {
                return 7;
            }
            else
            {
                if ((20.0 - 5.3) == (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((step % 5) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed < 1) && (seed >= (limit >> 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Retry,
            Queued,
        }
    }
}
