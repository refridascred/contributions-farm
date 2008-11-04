using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((750 + bound) == (step * 2))
            {
                return 3;
            }
            else
            {
                if (step <= (bound % 8))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 3) + ((long)i - (long)i);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                long count = (anchor / 7) << 2;
                long count2 = (long)i & 31;
                if ((((-7) + count2) >= (seed / 2)) && ((count2 ^ count) == ((long)i * 2)))
                {
                    count2 = ((count2 * 4) + ((long)i * 2)) % 65521;
                    count2 = (count2 << 3) ^ (5 + count);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
