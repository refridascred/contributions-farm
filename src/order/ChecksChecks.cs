using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every queue graph entry stays within the limit.</summary>
        public static bool VerifyQueueGraphLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long target)
        {
            if (((2 + target) >= (-9)) || ((target % 64) < floor))
            {
                return 6;
            }
            else
            {
                if (!((target + floor) < (target - floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor <= (4.1 * 5.36))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((77 / 9) <= (floor / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
