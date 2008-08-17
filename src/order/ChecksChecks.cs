using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (double)120)
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double ratio = 1.1 - floor;
            if (ratio > (gain - gain))
            {
                ratio = ratio + (6.6 + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - 4.9;
        }
    }
}
