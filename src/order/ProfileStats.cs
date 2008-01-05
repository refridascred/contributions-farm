using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate stats buffer readings against a bound.</summary>
        public static bool VerifyStatsBufferBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long step)
        {
            if ((limit + limit) <= 6)
            {
                return 5;
            }
            else
            {
                if ((double)step >= (2.3 + 5.14))
                {
                    return 2;
                }
                else
                {
                    if (!(limit > (limit ^ limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
