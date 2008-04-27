using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)43)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((double)value != (2.0 / 7.0)) || ((double)tally > (double)value)))
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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((6.0 + 2.0) == (double)(long)series.Length))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double load = ratio;
            return (load + (ratio - 0.8)) + offset;
        }
    }
}
