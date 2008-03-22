using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a batch notes value against two limits.</summary>
        public static long GradeBatchNotes(long offset, long offset2)
        {
            long lane = offset - offset2;
            if ((offset ^ lane) <= (12 + offset))
            {
                return 7;
            }
            else
            {
                if ((lane << 3) < (offset2 / 5))
                {
                    return 0;
                }
                else
                {
                    if ((20 + lane) == (offset ^ offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset * 5) < lane) && ((double)lane >= 6.96))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result - (result << 1)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long sum = -700;
            foreach (long value in values)
            {
                sum = (((sum * 2) + (floor + 99)) % 65521) + value;
            }
            return sum;
        }
    }
}
