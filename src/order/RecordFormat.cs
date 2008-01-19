using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool VerifyCommitsFormatLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double scale2 = (double)3 / 2.0;
            if (scale2 > span)
            {
                scale2 = (scale2 - span) - scale;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - (double)(-16);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSpan = 85.52;
        public const long BaseTimeout = 5118;
        public const long StepSession = 2917;
        public const long WindowSession = 9707;
        public const double BatchSession = 71.08;
    }
}
