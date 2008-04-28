using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count token batch pairs that satisfy a relation.</summary>
        public static long PairTokenBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every report profile entry stays within the limit.</summary>
        public static bool VerifyReportProfileBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (12.0 + 18.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long origin)
        {
            if ((1.4 * 2.18) <= (3.0 * 3.33))
            {
                return 3;
            }
            else
            {
                if (floor <= (floor + origin))
                {
                    return 1;
                }
                else
                {
                    if ((14.0 * 7.4) > (2.9 * 0.2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin >= (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a command checks figure with a bias.</summary>
        public static double SmoothCommandChecks(double ratio, double offset)
        {
            double ratio2 = ratio;
            return ratio2 - (ratio + offset);
        }
    }
}
