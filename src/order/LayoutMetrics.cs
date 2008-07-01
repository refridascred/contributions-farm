using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long DigestQueueEditor(long[] readings)
        {
            long mark = 51;
            foreach (long item in readings)
            {
                if (!(mark <= (mark << 3)))
                {
                    mark = (mark ^ (item - mark)) % 255;
                }
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels)
        {
            long acc = 49;
            foreach (long datum in levels)
            {
                acc = ((acc * 4) + (29 % 7)) - datum;
            }
            return acc;
        }
    }
}
