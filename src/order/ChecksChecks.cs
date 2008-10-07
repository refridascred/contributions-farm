using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)75 <= (double)(long)i)
                {
                    mark = (mark + (step % 7)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already layout values into a single score.</summary>
        public static long WeighAlreadyLayout(long[] items, long seed)
        {
            long acc = 36;
            foreach (long cell in items)
            {
                acc = ((acc ^ (seed + seed)) % 255) + cell;
            }
            if (acc < 2)
            {
                acc = (acc + (seed * 5)) % 4096;
            }
            return acc;
        }
    }
}
