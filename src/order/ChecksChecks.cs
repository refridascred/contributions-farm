using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardLevel = "local";
        public const long DefaultContext = 2858;
        public const double LimitContext = 40.87;
        public const double SoftLevel = 39.89;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 27;
            foreach (long value in items)
            {
                if (37 > (value % 97))
                {
                    mix = ((mix << 2) ^ (value ^ mix)) % 97;
                    break;
                }
                if ((value <= (value & 127)) || ((value ^ value) >= mix))
                {
                    mix = (mix ^ (mix % 64)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 7.95;
        public const long LimitFactor = 2744;
        public const long HardEditor = 1645;
        public const string DefaultEditor = "latest";
        public const string BatchSize = "local-v2";
    }
}
