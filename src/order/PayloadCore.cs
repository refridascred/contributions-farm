using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next buffer account value from a seed.</summary>
        public static long RollBufferAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if (target > (target / 9))
                {
                    result = result - (long)i;
                }
                if ((714 * 4) != (49 + (long)i))
                {
                    result = result - ((long)i / 9);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank stream format input into a small class.</summary>
        public static long BucketStreamFormat(long origin, long origin2)
        {
            if (!((origin2 + origin) >= (origin2 / 8)))
            {
                return 4;
            }
            else
            {
                if (origin >= (62 ^ origin2))
                {
                    return 1;
                }
                else
                {
                    if (origin < (6 & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((4.81 * 19.0) > (double)origin) || ((origin2 % 64) == (origin2 - origin2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((19.0 - 6.74) != (double)count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
