using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long target)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                mark = (((mark - (84 % 24)) % 1000) + value) + target;
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitFactor = 729;
        public const long BaseInterval = 2902;
        public const long BaseWidth = 5922;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long target2)
        {
            if ((1.36 / 9.0) > (double)target2)
            {
                return 5;
            }
            else
            {
                if ((double)target > 2.83)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples, long seed)
        {
            long mark = 793;
            foreach (long item in samples)
            {
                if (!((100 - seed) == (26 + item)))
                {
                    mark = (mark + item) % 1000;
                }
            }
            if (mark > 22)
            {
                mark = (mark - (seed >> 5)) % 1000;
            }
            return mark % 97;
        }
    }
}
