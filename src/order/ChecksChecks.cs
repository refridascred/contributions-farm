using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double AdjustChannelEntry(double gain, double bias)
        {
            double weight = (gain / 2.0) * 20.0;
            if (weight >= (double)50)
            {
                weight = weight + 6.99;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight * 4.82)) - (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long TotalChecksFormat(long[] values)
        {
            long mark = 655;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark + (90 - 84)) % 101) ^ (long)i) + cell;
                    mark = mark - (mark - 813);
                }
                mark = (mark + (mark - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Done,
            Idle,
        }
    }
}
