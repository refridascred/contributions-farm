using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "primary";
        public const string HardLevel = "legacy";
        public const long RetryLevel = 3726;
        public const string RetryFactor = "staging-1";

        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long PairRecordChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = result - (result << 3);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Paused,
            New,
        }
    }
}
