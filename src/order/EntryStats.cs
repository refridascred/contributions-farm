using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 914;
        public const long StepTimeout = 4609;
        public const double LimitLevel = 38.87;
        public const long CacheFactor = 3807;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of graph stats entries.</summary>
        public static long DigestGraphStats(long[] readings)
        {
            long carry = 49;
            foreach (long reading in readings)
            {
                if (((-938) >> 2) >= (carry - 22))
                {
                    carry = ((carry << 2) ^ (reading - carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long mark = 92;
            foreach (long sample in values)
            {
                mark = ((mark - (mark & 127)) + sample) + limit;
            }
            if (mark < 9)
            {
                mark = ((mark * 2) + (43 << 1)) % 101;
            }
            return mark % 97;
        }
    }
}
