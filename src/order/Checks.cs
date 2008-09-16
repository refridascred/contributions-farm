using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)step <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every window support entry stays within the limit.</summary>
        public static bool CheckWindowSupportRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "legacy-1";
        public const double SoftRoute = 62.04;
        public const long WindowCount = 3729;
        public const long BaseCount = 4691;
        public const long RetryScore = 8511;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double mean = (ratio * 5.2) * 4.0;
            if (mean < (ratio * 4.56))
            {
                mean = mean - 3.24;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + (mean - ratio);
        }
    }
}
