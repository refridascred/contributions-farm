using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 7) <= (10 - item))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (8.43 * 6.33))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long floor, long floor2)
        {
            if (!((floor2 - floor2) > (floor2 + floor)))
            {
                return 7;
            }
            else
            {
                if (42 > (22 + floor2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long seed)
        {
            if (!((seed - seed) < (seed + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= (step - step))
                {
                    return 7;
                }
                else
                {
                    if (seed < (seed / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double scale = floor;
            if (scale > (double)0)
            {
                scale = (scale + (double)5) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale / 8.0);
        }
    }
}
