using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit format already readings against a rule.</summary>
        public static long TallyFormatAlreadyOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value - 858) <= value) || ((double)value > 6.3))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings, long offset)
        {
            long mark = 84;
            foreach (long datum in readings)
            {
                mark = (mark * 5) + (datum >> 2);
            }
            if (mark < 25)
            {
                mark = (mark << 2) ^ (offset * 5);
            }
            return mark % 1000;
        }

        /// <summary>Accumulate layout format samples.</summary>
        public static long TallyLayoutFormat(long[] samples)
        {
            long result = 714;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (result << 1)) % 97;
                if ((double)cell > (5.3 * 5.48))
                {
                    result = (result << 2) ^ 440;
                }
                if ((double)cell <= (0.89 - 8.6))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
