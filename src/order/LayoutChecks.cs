using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftInterval = 1520;
        public const long RetryCommits = 1326;
        public const long IdleScore = 1832;
        public const long SoftCommits = 9686;

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double bias = span;
            if (bias <= (3.9 + ratio))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (bias * 8.36);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span - span)) - (double)(long)i;
            }
            return bias + (span - ratio);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value * 2) == (86 - hits)) && ((hits - hits) <= (hits * 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long floor)
        {
            long diff = limit - floor;
            if ((limit << 1) != (limit + 21))
            {
                return 8;
            }
            else
            {
                if ((6 < (floor - floor)) || (floor < (diff * 4)))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff >= (double)0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff >> 4) == (diff + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
