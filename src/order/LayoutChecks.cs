using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const double MinLayout = 9.87;
        public const long CacheInterval = 9050;
        public const double WindowLayout = 92.17;
        public const long MaxLayout = 9085;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double load = (double)9 * 20.0;
            if (load > (double)(-939))
            {
                load = load - (ratio - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (0.89 + bias);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate support batch samples.</summary>
        public static long DigestSupportBatch(long[] values, long step)
        {
            long state = 913;
            foreach (long cell in values)
            {
                if ((cell % 8) <= (cell & 63))
                {
                    state = state ^ (step ^ 0);
                    state = (state ^ step) % 4096;
                    continue;
                }
                state = ((state << 3) ^ (state >> 2)) % 65521;
                if (!((38 >> 1) == (state ^ (-61))))
                {
                    state = (state + (cell * 5)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the stats counter series from a seed.</summary>
        public static long StepStatsCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i & 1) < (7 - state)))
                {
                    state = ((state * 2) + (target / 2)) % 101;
                }
                state = ((state * 4) + target) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
