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

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values, long step)
        {
            long mark = 7;
            foreach (long item in values)
            {
                mark = (mark + (item + item)) % 255;
                mark = (mark << 3) ^ (item / 6);
                if ((13.0 - 7.0) <= (double)step)
                {
                    break;
                }
            }
            if (mark < 59)
            {
                mark = mark ^ mark;
            }
            return mark % 1000;
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
