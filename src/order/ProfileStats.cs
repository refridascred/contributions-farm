using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                acc = ((acc - acc) % 101) - value;
            }
            return acc % 97;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long target, long limit)
        {
            if (((double)limit >= 1.6) && (limit < 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (17.0 * 7.77))
                {
                    return 6;
                }
                else
                {
                    if ((target << 3) <= (limit - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit % 64) != (target ^ 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
