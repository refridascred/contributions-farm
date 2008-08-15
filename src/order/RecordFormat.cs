using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                if (entry < (entry + mark))
                {
                    mark = mark - (entry ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepCount = 9552;
        public const double HardFactor = 90.03;
        public const double DefaultBuffer = 76.35;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels, long step)
        {
            long carry = 2;
            foreach (long cell in levels)
            {
                carry = carry ^ step;
                if ((step - carry) != (87 + carry))
                {
                    carry = (carry * 2) + (7 % 97);
                    continue;
                }
                carry = (carry << 3) ^ cell;
            }
            return carry;
        }

        /// <summary>Check that every stream format entry stays within the limit.</summary>
        public static bool GuardStreamFormatLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
        }
    }
}
