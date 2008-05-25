using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many metrics format samples are out of range.</summary>
        public static long AuditMetricsFormatOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample >= (sample - 25)) && ((tally + sample) < (tally + limit))) || ((tally / 3) != (limit & 127)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long target)
        {
            long slot = offset + target;
            if (((double)offset == (9.0 + 9.7)) || ((offset ^ slot) == (69 ^ 48)))
            {
                return 0;
            }
            else
            {
                if ((67 + 44) < (offset - slot))
                {
                    return 4;
                }
                else
                {
                    if (!((target << 3) != (offset % 12)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - count) < sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes token series from a seed.</summary>
        public static long RollNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = carry + floor;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
