using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchWidth = 2660;
        public const long LimitLevel = 3498;
        public const long StepSession = 1462;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long origin)
        {
            long prev = floor + origin;
            if ((prev - floor) < (705 + prev))
            {
                return 6;
            }
            else
            {
                if (976 > (floor << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((double)prev <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin & 127) != (floor + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
