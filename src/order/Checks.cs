using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!(((long)i * 5) >= mark))
                {
                    mark = mark - ((long)i - (long)i);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc << 3) ^ (bound % 10)) % 255) - (long)i2;
                }
                acc = acc ^ (acc - acc);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double offset)
        {
            double gain = (double)(14 >> 1);
            if (gain <= (double)84)
            {
                gain = (gain + (9.0 / 4.0)) + ratio;
            }
            else
            {
                gain = gain + (offset / 3.0);
            }
            return gain - (double)448;
        }
    }
}
