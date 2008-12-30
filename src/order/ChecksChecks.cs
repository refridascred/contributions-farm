using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph queue counter forward.</summary>
        public static long RollGraphQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((0.75 / 9.0) == (double)floor)
                {
                    acc = acc + (floor + acc);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if (((-5) << 3) > target)
                {
                    mark = (mark + (target + target)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
