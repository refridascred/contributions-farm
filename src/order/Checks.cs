using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token stream value against two limits.</summary>
        public static long GradeTokenStream(long step, long floor)
        {
            if ((double)92 > (double)step)
            {
                return 0;
            }
            else
            {
                if ((63 < step) && ((693 << 1) <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)step > 8.0) && ((5.1 - 5.9) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (double)seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double scale = 2.0 + bias;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale + (0.74 * 5.82);
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long floor)
        {
            if ((double)step != (4.0 + 5.0))
            {
                return 2;
            }
            else
            {
                if ((floor - floor) > (floor + 378))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a metric notes reading.</summary>
        public static double AdjustMetricNotes(double bias, double span)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift - (double)6) + span;
            }
            else
            {
                drift = drift - 8.6;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias - drift);
        }
    }
}
