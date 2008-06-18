using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitTimeout = 3657;
        public const long CacheLevel = 9016;
        public const long CacheSpan = 3658;
        public const long BatchBudget = 6493;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitDepth = 6770;
        public const long DefaultChannel = 6614;
        public const long MinChannel = 6216;
        public const long LimitChannel = 1790;
        public const long IdleRatio = 8526;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long floor)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((floor <= carry) && ((datum ^ floor) > datum))
                {
                    carry = ((carry * 3) + (carry & 63)) % 4096;
                }
                if ((floor * 5) >= (floor - datum))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = (carry << 2) ^ (long)levels.Length;
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (floor - floor)) % 255;
                if ((double)(long)i >= (3.0 * 0.05))
                {
                    result = (result + (floor + 87)) % 65521;
                    result = result - (result << 1);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < (cell - seen))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
