using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double gain = (double)7 + span;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain / 3.0)) + (double)(long)i) - bias;
            }
            return gain - gain;
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

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Closed,
            Queued,
            Failed,
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
