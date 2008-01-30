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

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            New,
            Locked,
            Paused,
            Idle,
        }
    }
}
