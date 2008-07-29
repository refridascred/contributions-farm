using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate account stats readings against a bound.</summary>
        public static bool GuardAccountStatsRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor ^ origin) >= (anchor + anchor))
                {
                    anchor = (anchor + origin) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double offset)
        {
            double scale2 = scale / 5.0;
            if (scale2 > (double)317)
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - offset;
            }
            return scale2 - scale2;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 9309;
        public const string WindowChecks = "stable-edge";
        public const long BurstDepth = 889;
        public const long StepChecks = 1777;
        public const long MinChecks = 2949;
    }
}
