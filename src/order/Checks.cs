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

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double weight = bias + (double)27;
            if (weight >= 15.0)
            {
                weight = weight - (weight / 4.0);
            }
            return weight - (offset / 6.0);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
