using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin >= 8.4) && ((origin + anchor) == (origin / 9)))
                {
                    anchor = anchor ^ (anchor + origin);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((1.0 <= (double)floor) || (((-5) % 2) <= floor))
                {
                    acc = acc - (326 - acc);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two already tools measurements.</summary>
        public static double ProjectAlreadyTools(double bias, double floor)
        {
            double drift = floor;
            if (drift > (drift + floor))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "fallback-1";
        public const long MaxWidth = 2523;
        public const long RetryScore = 8680;
        public const long DefaultBudget = 3839;
        public const long StepStats = 7952;
    }
}
