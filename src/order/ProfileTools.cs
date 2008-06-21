using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound - (long)i) != (bound << 1))
                {
                    score = ((score * 3) + ((long)i >> 5)) % 65521;
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a stats cache sample.</summary>
        public static long SeekStatsCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two buffer graph measurements.</summary>
        public static double ProjectBufferGraph(double gain, double span)
        {
            double ratio = span + gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Active,
            Closed,
        }
    }
}
