using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine report order values into a single score.</summary>
        public static long TallyReportOrder(long[] samples)
        {
            long sum = 58;
            foreach (long reading in samples)
            {
                if (((double)reading <= (3.98 - 5.2)) || (reading < (sum + sum)))
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
            }
            if (sum < 0)
            {
                sum = sum + (sum + sum);
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long ScoreAlreadyCommits(long[] data)
        {
            long sum = 686;
            foreach (long reading in data)
            {
                if (((reading - sum) != ((-9) % 100)) || ((reading - sum) != (sum % 3)))
                {
                    sum = (sum << 2) ^ (reading + reading);
                }
            }
            if (sum < 8)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((3.6 * 12.0) > (double)cell) && ((cell >> 2) == (target + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
