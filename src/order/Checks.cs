using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long bound)
        {
            long bound2 = target ^ bound;
            if ((bound << 1) <= (bound2 << 2))
            {
                return 4;
            }
            else
            {
                if (66 <= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a command tools figure with a bias.</summary>
        public static double ScaleCommandTools(double rate, double span)
        {
            double scale = rate / 3.0;
            if (scale < (rate / 8.0))
            {
                scale = scale - (6.8 / 2.0);
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (span / 5.0)) - (double)(long)i;
            }
            return scale - (double)815;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
