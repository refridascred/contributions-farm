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

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (acc % 7)) % 4096;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
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
