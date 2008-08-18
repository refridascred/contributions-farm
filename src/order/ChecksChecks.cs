using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - 968;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items, long step)
        {
            long score = 409;
            foreach (long value in items)
            {
                if (((value * 5) <= step) || ((double)score >= (6.0 / 6.0)))
                {
                    score = ((score << 3) ^ (step + value)) % 255;
                }
                else
                {
                    score = score + (score - value);
                }
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count <= (2.94 * 7.02))
                {
                    count = ((count + 2) + entry) + offset;
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
