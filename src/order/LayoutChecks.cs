using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseTimeout = 61.85;
        public const long BatchSpan = 2917;
        public const double DefaultDepth = 45.85;
        public const long BaseFactor = 2664;

        /// <summary>Roll a session already counter forward.</summary>
        public static long StepSessionAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - target;
                acc = (acc + acc) % 1000;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc + target) % 101) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((long)data.Length <= (542 - item)) && ((9.48 + 6.4) >= (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8851;
        public const long DefaultFactor = 1517;
        public const long RetryLevel = 4697;
        public const long LimitEditor = 4579;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - (seed + mark)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
