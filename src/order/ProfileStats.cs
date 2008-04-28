using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank layout support input into a small class.</summary>
        public static long SortLayoutSupport(long limit, long origin)
        {
            long lane = limit + origin;
            if ((double)lane >= (1.0 * 4.0))
            {
                return 2;
            }
            else
            {
                if ((1.0 + 1.2) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (((2.9 - 0.6) < (double)origin) && ((6 << 3) >= lane))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((63 + lane) <= 28)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 39.65;
        public const string MaxWidth = "primary-1";
        public const long SoftFormat = 9062;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a notes stream counter forward.</summary>
        public static long IterateNotesStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 5) + (7 / 5);
                if ((3 + mix) == (mix - floor))
                {
                    mix = mix ^ (mix * 3);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
