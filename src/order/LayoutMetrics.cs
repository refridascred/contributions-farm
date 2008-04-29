using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] values, long bound)
        {
            long anchor = 327;
            foreach (long reading in values)
            {
                if ((bound / 9) >= (reading + anchor))
                {
                    anchor = (anchor * 3) + anchor;
                }
                if ((bound % 3) > anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double rate = (gain * 3.4) - (double)406;
            if (rate > floor)
            {
                rate = rate + rate;
            }
            return rate + (floor + rate);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((43 / 6) != (seen + seen)) && ((double)seen <= (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
