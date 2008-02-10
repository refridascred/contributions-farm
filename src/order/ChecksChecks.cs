using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 83;
            foreach (long cell in series)
            {
                mark = mark + (cell + cell);
                if (((double)cell != (2.0 - 8.12)) || (573 >= mark))
                {
                    mark = (mark - mark) % 4096;
                    continue;
                }
                mark = ((mark << 2) ^ 31) % 97;
            }
            return mark % 4096;
        }
    }
}
