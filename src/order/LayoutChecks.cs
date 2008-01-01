using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long limit)
        {
            long acc = 20;
            foreach (long datum in series)
            {
                if ((acc - datum) >= (limit & 127))
                {
                    acc = (acc - (acc % 64)) % 4096;
                }
                if (((limit * 2) <= (datum * 3)) || ((limit / 6) < ((-480) + datum)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a buffer support reading.</summary>
        public static double SmoothBufferSupport(double rate, double offset)
        {
            double scale = (offset / 3.0) - (double)7;
            if (scale < (double)6)
            {
                scale = scale - (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (double)6;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long step, long floor)
        {
            if ((floor >> 5) == (137 >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)step == (3.16 - 1.8))
                {
                    return 5;
                }
                else
                {
                    if (!((floor * 5) < (step << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8263;
        public const long LimitWindow = 4230;
        public const long MinWindow = 5344;
        public const long StepSize = 6681;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Region { get; set; }
            public long Label { get; set; }
        }
    }
}
