using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleFactor = 1899;
        public const long BaseInterval = 1428;
        public const long HardBuffer = 1126;
        public const string WindowSize = "open-edge";
        public const long SoftInterval = 9895;

        /// <summary>Define session limits and defaults.</summary>
        public const string MinWidth = "open-edge";
        public const long SoftScore = 1534;
        public const string LimitSession = "fallback-1";
        public const double SoftSession = 63.95;
        public const long DefaultBudget = 6910;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (mix - mix)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long WeighRecordPayload(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                if (!((876 / 7) != (state >> 5)))
                {
                    state = (state << 3) ^ (item % 12);
                    break;
                }
                if ((item + 78) == (item / 9))
                {
                    state = (state - (item % 3)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ item;
                }
            }
            return state;
        }
    }
}
