using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "fallback-edge";
        public const long BatchCount = 8355;
        public const string SoftWidth = "legacy-v2";

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Paused,
            Draft,
            New,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double rate, double floor)
        {
            double scale = (floor * 3.57) * 1.4;
            if (scale > 5.39)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (scale + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + floor) + (double)(long)i;
            }
            return scale + (rate / 9.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 3810;
        public const long CacheFilter = 8908;
        public const long MinFilter = 9982;
        public const double StepDepth = 42.88;
        public const double RetryFilter = 60.05;
    }
}
