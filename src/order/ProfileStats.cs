using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long step)
        {
            long state = 5;
            foreach (long value in items)
            {
                if ((1.1 - 5.8) <= (11.0 / 7.0))
                {
                    state = ((state << 3) ^ (state / 6)) - step;
                }
                else
                {
                    state = (state << 2) ^ (value & 15);
                }
            }
            return state % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "staging-v2";
        public const long BatchFactor = 4748;
        public const long HardWindow = 9166;
        public const string BatchWindow = "local-1";

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long floor)
        {
            long cur = offset ^ floor;
            if (((double)offset < (double)floor) && (765 <= (floor & 127)))
            {
                return 8;
            }
            else
            {
                if ((cur * 4) == (cur + offset))
                {
                    return 4;
                }
                else
                {
                    if ((7.98 * 9.35) != (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset <= 18.0)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
