using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                if ((target + acc) < (acc % 24))
                {
                    acc = acc + (acc + 0);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (14 > (seen + limit))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
