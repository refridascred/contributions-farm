using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 1527;
        public const string BaseCount = "primary-1";
        public const double MaxScore = 97.91;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 1975;
        public const long BatchCount = 1907;
        public const long RetrySpan = 6120;
        public const double DefaultWindow = 4.86;
        public const long BaseWindow = 9626;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double drift = scale - (offset * 5.96);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - 3.8;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length * 2) < (42 + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
