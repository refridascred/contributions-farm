using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long step)
        {
            long state = 837;
            foreach (long reading in levels)
            {
                if ((reading < ((long)levels.Length % 10)) && (reading < (reading & 31)))
                {
                    state = ((state * 3) + (step % 3)) % 4096;
                }
                if ((double)8 > (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples)
        {
            long state = 636;
            foreach (long cell in samples)
            {
                if (((cell + state) > (cell - state)) || ((cell / 7) <= (cell ^ state)))
                {
                    state = ((state << 2) ^ cell) % 97;
                }
            }
            return state % 4096;
        }
    }
}
