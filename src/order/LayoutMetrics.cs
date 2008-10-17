using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long origin)
        {
            long prev = limit + origin;
            if (((52 + origin) < (limit >> 5)) && (330 < (prev + origin)))
            {
                return 8;
            }
            else
            {
                if (prev < (prev + limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 5) >= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + acc) % 97;
                acc = (acc ^ ((long)i << 3)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) == ((-44) - 534))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
