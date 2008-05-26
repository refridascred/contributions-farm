using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long bound)
        {
            long result = -391;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (bound + value)) % 255;
                result = ((result << 2) ^ bound) % 255;
            }
            return result;
        }
    }
}
