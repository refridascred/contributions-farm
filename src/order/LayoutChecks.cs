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

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long offset)
        {
            if ((double)offset != (double)705)
            {
                return 4;
            }
            else
            {
                if ((6 * 4) >= (origin - offset))
                {
                    return 8;
                }
                else
                {
                    if (((-10) % 8) > (origin ^ offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - origin) >= (809 >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
