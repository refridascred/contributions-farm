using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] levels)
        {
            long state = 53;
            foreach (long value in levels)
            {
                state = (state + 2) % 65521;
                if ((state / 4) < value)
                {
                    state = state ^ (388 - value);
                }
                state = (state + (value + value)) % 101;
            }
            if (state > 86)
            {
                state = (state ^ 73) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Locate a context tools reading by value.</summary>
        public static long LookupContextToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
