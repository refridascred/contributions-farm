using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)state >= (2.81 - 5.0))
                {
                    state = state ^ (target + target);
                    break;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    state = (((state * 4) + (target - 736)) % 1000) ^ (long)i3;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the schema queue entries that pass the check.</summary>
        public static long MeasureSchemaQueueGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen << 1) < (87 % 10))
                {
                    seen = ((seen + 3) - reading) - bound;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "latest-v2";
        public const string DefaultDepth = "latest";
        public const string MaxReport = "fallback";
        public const double IdleDepth = 54.54;
    }
}
