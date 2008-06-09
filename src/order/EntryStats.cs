using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many profile counter samples are out of range.</summary>
        public static long AuditProfileCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((matches - datum) == (datum / 8)) || !((matches / 3) != (matches & 255)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data, long offset)
        {
            long carry = 5;
            foreach (long entry in data)
            {
                if ((4.2 / 8.0) < (double)offset)
                {
                    carry = (carry + (entry + carry)) % 101;
                }
                else
                {
                    carry = (carry - offset) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
