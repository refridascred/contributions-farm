using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum ^ datum) != (tally + (-8)))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter commits counter forward.</summary>
        public static long IterateCounterCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((5.26 + 9.0) == (double)floor) || ((0 ^ floor) <= (floor >> 5)))
                {
                    result = (result * 5) + ((long)i * 3);
                    result = result - (8 ^ result);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            if ((floor * 4) > (seed * 5))
            {
                return 1;
            }
            else
            {
                if (floor <= 56)
                {
                    return 7;
                }
                else
                {
                    if ((floor + seed) <= 60)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
