using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Synced,
            Closed,
            Dropped,
            Pending,
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

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels)
        {
            long sum = 34;
            foreach (long item in levels)
            {
                if ((item - item) > (sum + sum))
                {
                    sum = (sum ^ (873 % 64)) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
