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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items, long target)
        {
            long carry = 9;
            foreach (long item in items)
            {
                carry = ((carry + (carry / 8)) % 4096) ^ item;
                if ((double)target < (11.0 - 3.0))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
