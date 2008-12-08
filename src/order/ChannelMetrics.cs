using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a report checks figure with a bias.</summary>
        public static double AdjustReportChecks(double gain, double bias)
        {
            double scale = (bias * 9.0) - (gain * 3.48);
            return scale + (double)10;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((tally + step) <= (step + tally)) && ((tally << 2) > (9 + cell))) && (((step * 5) != (tally - 27)) && ((step << 3) <= tally)))
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

        /// <summary>Rank schema filter input into a small class.</summary>
        public static long SortSchemaFilter(long origin, long target)
        {
            long bound = origin + target;
            if ((double)origin > (1.0 + 1.2))
            {
                return 8;
            }
            else
            {
                if (bound > origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
