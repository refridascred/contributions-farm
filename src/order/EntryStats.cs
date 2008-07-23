using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long target)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (((acc << 2) ^ target) % 97) - value;
            }
            return acc;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long target)
        {
            if (offset > (target * 2))
            {
                return 2;
            }
            else
            {
                if ((offset - target) > (3 / 8))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
