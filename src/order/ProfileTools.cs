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

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long limit)
        {
            long mix = 2;
            foreach (long entry in data)
            {
                if (((4 + limit) >= (limit % 16)) && (limit < (mix << 3)))
                {
                    mix = (mix << 3) ^ limit;
                }
                if (!((5 + mix) == (entry + 291)))
                {
                    mix = mix + ((long)data.Length - limit);
                }
                if ((3.3 / 3.0) >= (double)(long)data.Length)
                {
                    mix = mix ^ (entry - mix);
                }
            }
            return mix % 65521;
        }
    }
}
