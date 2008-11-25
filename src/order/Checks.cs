using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((8 + origin) > (origin << 2))
            {
                return 1;
            }
            else
            {
                if ((delta + origin) == (7 + delta))
                {
                    return 5;
                }
                else
                {
                    if (!((origin2 ^ 7) == ((-7) * 2)))
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

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double load = (bias * 9.0) - bias2;
            return load + (bias - bias2);
        }

        /// <summary>Audit layout filter readings against a rule.</summary>
        public static long AuditLayoutFilterMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)limit == (18.0 * 3.0)) || (59 < ((long)data.Length / 4)))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
