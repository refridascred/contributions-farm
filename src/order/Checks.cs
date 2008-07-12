using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 5.87)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((total << 2) > total)
                {
                    total = (total + ((long)i - 76)) % 1000;
                }
                else
                {
                    total = (total + (bound + 70)) % 4096;
                    total = (total + (total / 8)) % 65521;
                }
                total = (total - (0 - total)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 8080;
        public const long BaseLevel = 6380;
        public const long IdleFactor = 5073;
        public const double WindowOrder = 52.75;
        public const long SoftCount = 434;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long acc = 7;
            foreach (long value in levels)
            {
                acc = (acc + (acc * 3)) + value;
            }
            if (acc > (-469))
            {
                acc = (acc + (acc ^ acc)) % 255;
            }
            return acc;
        }
    }
}
