using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long origin)
        {
            long total = 49;
            foreach (long entry in levels)
            {
                total = total - (62 * 2);
                total = total + (origin - origin);
                if ((double)entry <= 1.0)
                {
                    total = (total - (total + total)) % 1000;
                }
                if ((total << 1) != (entry ^ entry))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            if (98 >= (offset & 7))
            {
                return 3;
            }
            else
            {
                if (((-446) - 332) >= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound / 7) == (bound >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
