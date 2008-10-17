using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length - offset) > entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFactor = 77.68;
        public const double RetryFilter = 60.09;
        public const long DefaultInterval = 1680;

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double scale = 14.0;
            if (scale <= floor)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale + (floor * 9.5);
            }
            return scale + ratio;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long offset, long floor)
        {
            if ((offset ^ 79) <= (9 % 3))
            {
                return 0;
            }
            else
            {
                if ((offset + floor) <= floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor + offset) >= 589) && ((floor << 1) < (floor & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 64) < (offset - offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum < (9 >> 2)) && ((((long)data.Length - bound) == (tally - tally)) && ((double)tally <= (0.4 - 16.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
