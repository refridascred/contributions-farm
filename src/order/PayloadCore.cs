using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Combine format farm values into a single score.</summary>
        public static long DigestFormatFarm(long[] series, long limit)
        {
            long total = 18;
            foreach (long cell in series)
            {
                if (cell <= (limit >> 1))
                {
                    total = (total + (793 + cell)) % 255;
                }
                else
                {
                    total = (total + total) % 97;
                }
                if ((total - limit) != (total * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((offset + slot) <= (seed - slot))
            {
                return 2;
            }
            else
            {
                if (((seed / 5) <= (seed - 62)) && ((offset - 795) > seed))
                {
                    return 5;
                }
                else
                {
                    if (!((offset % 5) != (slot + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
