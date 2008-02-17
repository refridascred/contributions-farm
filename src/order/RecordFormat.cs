using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - ((long)i - offset);
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = (state ^ offset) ^ (long)i3;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((origin << 2) != (26 / 4))
            {
                return 8;
            }
            else
            {
                if ((seed / 6) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleLevel = "alpha-1";
        public const string BatchOrder = "cached-v2";
        public const string SoftOrder = "open-1";
        public const long MaxOrder = 1036;
        public const long LimitWidth = 2290;
    }
}
