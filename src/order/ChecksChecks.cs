using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long floor)
        {
            if ((step & 127) >= step)
            {
                return 6;
            }
            else
            {
                if ((step + floor) > (floor / 4))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 2) != (step - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long step)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((step & 31) >= (value >> 4))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 4096;
                }
                mix = (mix * 4) + (value << 3);
            }
            if (mix < (-7))
            {
                mix = mix - (mix + step);
            }
            return mix % 4096;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long target, long floor)
        {
            long diff = target + floor;
            if (((diff % 2) != (target % 2)) || (862 < (diff >> 3)))
            {
                return 0;
            }
            else
            {
                if (!((0 / 2) <= (floor + diff)))
                {
                    return 5;
                }
                else
                {
                    if (((target >> 2) <= (target ^ floor)) && (816 <= (target % 60)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((diff + diff) > (diff & 1))
                        {
                            return 8;
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
