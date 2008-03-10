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

        /// <summary>Derive the next account graph value from a seed.</summary>
        public static long RollAccountGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
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
