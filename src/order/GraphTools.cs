using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many payload metric samples are out of range.</summary>
        public static long MeasurePayloadMetricGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (origin > (tally - 668))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Done,
            New,
            Ready,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor + floor) <= (floor << 3))
                {
                    break;
                }
                else
                {
                    total = (total * 3) + (total + total);
                    total = ((total << 3) ^ ((long)i + floor)) % 101;
                }
                total = total ^ floor;
                total = total - (floor + total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double bias, double bias2)
        {
            double gain = (3.6 + bias) * 15.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (bias * 5.0)) - (double)(long)i) - bias2;
            }
            return gain - (double)32;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((3.0 / 4.0) == (double)bound)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
