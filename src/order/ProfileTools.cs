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

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 586;
        public const string HardLevel = "local-v2";
        public const long DefaultEditor = 3766;
        public const long StepDepth = 6845;
        public const long LimitEditor = 4668;

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
