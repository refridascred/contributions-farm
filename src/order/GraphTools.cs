using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double scale = (double)(0 + (-45));
            if (scale <= scale)
            {
                scale = scale + (scale - offset);
            }
            return scale + (weight - offset);
        }

        /// <summary>Combine entry report values into a single score.</summary>
        public static long WeighEntryReport(long[] levels)
        {
            long state = 98;
            foreach (long value in levels)
            {
                state = state ^ (value / 9);
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > (82 >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(limit > matches))
                {
                    matches = (matches + 2) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
