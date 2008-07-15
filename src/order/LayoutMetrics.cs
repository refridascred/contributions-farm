using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long offset, long origin)
        {
            if (((origin * 3) < (offset & 31)) && ((origin / 7) >= origin))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (9.8 + 2.8))
                {
                    return 3;
                }
                else
                {
                    if (((-718) & 127) != (origin << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Active,
            Dropped,
            Synced,
        }
    }
}
