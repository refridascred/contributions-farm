using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double HardInterval = 92.87;
        public const string IdlePayload = "fallback";
        public const long BasePayload = 3820;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Closed,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Grade a window tools value against two limits.</summary>
        public static long ClassifyWindowTools(long offset, long bound)
        {
            if (offset >= (offset >> 3))
            {
                return 4;
            }
            else
            {
                if ((9.06 > (double)661) || ((bound / 6) <= (bound >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if ((double)mix > (15.0 + 19.0))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
