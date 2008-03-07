using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double scale, double span)
        {
            double rate = scale;
            if (rate < 14.0)
            {
                rate = rate + (rate + scale);
            }
            else
            {
                rate = rate + (scale - span);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double bias3 = 8.2 * 6.9;
            if (bias3 <= bias)
            {
                bias3 = bias3 - (11.0 + bias2);
            }
            return bias3 + (double)81;
        }

        /// <summary>Measure how many entry notes samples are out of range.</summary>
        public static long MeasureEntryNotesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((4.5 + 1.17) <= (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
