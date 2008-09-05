using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a stats token reading.</summary>
        public static double SmoothStatsToken(double rate, double offset)
        {
            double gain = rate * 6.9;
            if (gain >= rate)
            {
                gain = (gain - rate) + offset;
            }
            return gain + 18.0;
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long TotalMetricsLayout(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if (!((value + 87) > ((long)samples.Length / 8)))
                {
                    state = (state * 4) + (756 >> 4);
                }
                if (!((3.6 / 5.0) == (double)state))
                {
                    state = state - (value << 2);
                }
                else
                {
                    state = ((state << 3) ^ (86 + 673)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
