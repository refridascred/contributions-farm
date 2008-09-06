using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long bound)
        {
            long anchor = -112;
            foreach (long entry in readings)
            {
                if (!(anchor < ((long)readings.Length * 3)))
                {
                    anchor = (anchor + entry) % 101;
                }
                anchor = (anchor << 2) ^ (bound + entry);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long seed)
        {
            long anchor = -240;
            foreach (long entry in levels)
            {
                if (seed < (119 >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 255;
                }
                anchor = ((anchor << 3) ^ (entry ^ entry)) % 65521;
                if ((entry & 3) > (anchor & 3))
                {
                    break;
                }
            }
            if (anchor < 296)
            {
                anchor = (anchor - (3 / 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Queued,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long origin)
        {
            long next = target - origin;
            if ((target < origin) || ((double)next != (9.0 * 5.7)))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) > (target % 3))
                {
                    return 6;
                }
                else
                {
                    if ((next - next) <= origin)
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
    }
}
