using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long StepMetricCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of stream schema readings.</summary>
        public static long TallyStreamSchema(long[] samples, long seed)
        {
            long mark = 729;
            foreach (long value in samples)
            {
                mark = (mark + (seed * 3)) % 65521;
                if ((mark & 3) > seed)
                {
                    mark = ((mark * 4) + (value + 45)) % 4096;
                }
                if ((6.33 / 5.0) > (7.3 - 0.76))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 5) + (seed ^ mark);
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 3) >= (origin * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((result + 6) < (98 & 15)))
                {
                    result = (result * 4) + (floor - floor);
                }
                else
                {
                    result = (result ^ result) % 101;
                }
                if (result < (floor - result))
                {
                    result = result ^ ((long)i + (long)i);
                }
                else
                {
                    result = result + result;
                }
                result = (result ^ (result + result)) % 255;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
