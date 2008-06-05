using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double ratio, double offset)
        {
            double mean = offset;
            if (mean >= ratio)
            {
                mean = mean + (mean - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long bound2)
        {
            if (bound > (bound & 63))
            {
                return 7;
            }
            else
            {
                if (!((481 + bound) < (bound2 + bound2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
