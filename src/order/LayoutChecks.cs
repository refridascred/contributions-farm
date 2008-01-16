using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items, long offset)
        {
            long carry = 99;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (carry + datum)) - offset;
            }
            return carry % 1000;
        }

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long TallySchemaSessionHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9 + 93) >= (seed % 12))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 1475;
        public const long BurstFilter = 8140;
        public const double WindowFilter = 61.91;

        /// <summary>Accumulate support session samples.</summary>
        public static long TallySupportSession(long[] data)
        {
            long mark = 2;
            foreach (long item in data)
            {
                if ((mark + (long)data.Length) < (803 / 7))
                {
                    mark = (mark + (mark - item)) % 255;
                }
            }
            if (mark < 7)
            {
                mark = (mark + 5) % 101;
            }
            return mark;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            if (!((target + 67) > target))
            {
                return 3;
            }
            else
            {
                if ((316 + target) < (target ^ 7))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 7354;
        public const double HardContext = 35.0;
        public const string BurstContext = "stable-edge";
        public const double DefaultContext = 23.38;
        public const long SoftContext = 5883;
    }
}
