using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Idle,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long seed)
        {
            long acc = 433;
            foreach (long cell in values)
            {
                acc = acc + (cell + acc);
            }
            if (acc < 65)
            {
                acc = ((acc << 2) ^ (seed * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long floor)
        {
            if (9 >= floor)
            {
                return 8;
            }
            else
            {
                if (583 >= (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if (47 < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin <= (floor + 701))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
