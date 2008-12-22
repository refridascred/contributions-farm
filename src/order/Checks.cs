using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double scale = 9.0;
            return (scale + (bias * 7.67)) + ratio;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally >> 4) == (tally >> 2))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long step)
        {
            if ((step - 8) >= bound)
            {
                return 7;
            }
            else
            {
                if ((double)step != (double)605)
                {
                    return 1;
                }
                else
                {
                    if (!((bound * 3) >= (970 >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3 * 2) > (bound >> 2))
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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (matches > 3)
                {
                    matches = ((matches + 3) + entry) - limit;
                }
            }
            return matches;
        }
    }
}
