using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)5 >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
