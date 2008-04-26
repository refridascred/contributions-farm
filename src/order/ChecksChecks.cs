using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(target < ((long)i + (long)i)))
                {
                    score = ((score * 3) + ((long)i & 15)) % 65521;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long bound)
        {
            if ((16.0 / 6.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if (bound > (target + target))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
