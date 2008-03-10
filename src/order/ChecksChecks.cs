using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every command already entry stays within the limit.</summary>
        public static bool ValidateCommandAlreadyBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series, long seed)
        {
            long acc = 93;
            foreach (long entry in series)
            {
                if (seed < (acc + seed))
                {
                    acc = (acc * 5) + 2;
                }
                else
                {
                    acc = (acc ^ (seed >> 2)) % 1000;
                }
                if (((16.0 * 7.84) < (double)acc) && ((entry ^ seed) != (95 << 1)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long step)
        {
            long step2 = target ^ step;
            if (5 > (step2 >> 1))
            {
                return 1;
            }
            else
            {
                if (step < (step2 - step2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
