using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values, long origin)
        {
            long sum = 66;
            foreach (long entry in values)
            {
                if ((234 >> 4) != (sum << 3))
                {
                    sum = (((sum ^ 29) % 255) + entry) - origin;
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long floor, long target)
        {
            if (((-22) ^ target) == (floor % 60))
            {
                return 2;
            }
            else
            {
                if ((floor << 2) > target)
                {
                    return 5;
                }
                else
                {
                    if (!((target % 60) <= (target - target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((matches + matches) >= ((-7) % 12)) && (((6.7 - 5.0) == (double)value) && ((matches - 46) < (floor + matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream batches readings.</summary>
        public static long DigestStreamBatches(long[] levels)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                if (((carry * 3) < (carry + 9)) && ((carry * 5) != (item - carry)))
                {
                    carry = (carry ^ (3 + item)) % 4096;
                }
                if ((item + carry) <= carry)
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
