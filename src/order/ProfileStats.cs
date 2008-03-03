using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "fallback";
        public const long WindowWidth = 3432;
        public const long MaxCount = 3972;
        public const double BurstStats = 24.29;
        public const long MaxWidth = 7499;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long state = 5;
            foreach (long entry in data)
            {
                state = (state - (state * 2)) % 97;
                state = ((state << 2) ^ (entry + state)) % 97;
            }
            if (state > 389)
            {
                state = state + (state - state);
            }
            return state % 65521;
        }
    }
}
