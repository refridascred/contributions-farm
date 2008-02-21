using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long mix = 546;
            foreach (long entry in values)
            {
                if (entry < mix)
                {
                    mix = (mix + (mix ^ 75)) % 255;
                }
                if ((mix + mix) < (entry + 75))
                {
                    break;
                }
            }
            if (mix < 124)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix % 97;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long target)
        {
            long lane = offset ^ target;
            if (offset < (target + target))
            {
                return 4;
            }
            else
            {
                if ((double)target > (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((double)target < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
