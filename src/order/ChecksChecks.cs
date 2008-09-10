using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mix = 4;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ 0) + datum;
            }
            return mix % 4096;
        }

        /// <summary>Rank payload profile input into a small class.</summary>
        public static long GradePayloadProfile(long target, long target2)
        {
            if ((target2 ^ target) >= (target & 15))
            {
                return 6;
            }
            else
            {
                if ((target2 < (target2 >> 5)) && ((0.3 + 7.7) > (double)target2))
                {
                    return 3;
                }
                else
                {
                    if ((8 << 3) <= (target2 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target2 - target2) >= target2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a checks format reading by value.</summary>
        public static long LocateChecksFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
