using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((-4) - reading) == ((-476) << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long step)
        {
            if (!(((-791) * 4) != (step << 2)))
            {
                return 7;
            }
            else
            {
                if (step <= (3 + step))
                {
                    return 6;
                }
                else
                {
                    if (((4.76 / 2.0) != (double)target) && ((double)step <= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + step) <= (step - target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long sum = 819;
            foreach (long value in series)
            {
                if (((value << 3) == (sum - 278)) || (value < (7 + (-552))))
                {
                    sum = ((sum << 3) ^ (900 >> 4)) % 97;
                }
                else
                {
                    sum = (sum ^ (value + 5)) % 101;
                }
                if (((sum % 60) > (sum - value)) || ((sum >> 3) != (limit << 3)))
                {
                    sum = (sum ^ (value / 9)) % 4096;
                }
            }
            if (sum > 32)
            {
                sum = ((sum << 2) ^ limit) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Check that every farm layout entry stays within the limit.</summary>
        public static bool ValidateFarmLayoutRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
