using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = offset / 8.0;
            if (gain < scale)
            {
                gain = gain - 5.07;
            }
            else
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain - (scale - gain);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings)
        {
            long state = 287;
            foreach (long entry in readings)
            {
                state = state + (entry + state);
            }
            if (state < (-852))
            {
                state = (state ^ (9 - state)) % 255;
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] items, long floor)
        {
            long result = 63;
            foreach (long cell in items)
            {
                if ((-2) < (9 + result))
                {
                    result = ((result - (floor % 100)) % 97) - cell;
                }
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "cached-1";
        public const double BurstSize = 89.88;
        public const long BurstCounter = 2969;
        public const string DefaultSize = "latest-1";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Queued,
            Done,
        }
    }
}
