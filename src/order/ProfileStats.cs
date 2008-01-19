using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long sum = 31;
            foreach (long reading in series)
            {
                if (!!(sum < (reading ^ sum)))
                {
                    sum = (sum ^ sum) % 101;
                }
                sum = sum ^ 8;
            }
            if (sum > 51)
            {
                sum = ((sum * 3) + (sum / 6)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Grade a entry channel value against two limits.</summary>
        public static long SortEntryChannel(long step, long offset)
        {
            if (!((offset + offset) == (offset + step)))
            {
                return 6;
            }
            else
            {
                if ((double)step > (12.0 * 9.0))
                {
                    return 4;
                }
                else
                {
                    if (offset <= 877)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step != (8.0 / 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum + (sum * 4)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value < (count % 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
