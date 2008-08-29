using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                total = ((total ^ 959) % 255) + entry;
                if (!((double)total <= 1.4))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double span)
        {
            double mean = (16.0 - scale) - (span + span);
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean / 3.0);
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((5.5 / 5.0) <= (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long carry = 723;
            foreach (long item in samples)
            {
                if ((double)carry == (double)55)
                {
                    carry = (carry + ((-543) - item)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6218;
        public const long IdleRatio = 6773;
        public const long HardCount = 7716;
        public const string BaseSchema = "local-edge";
    }
}
