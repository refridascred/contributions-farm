using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long sum = 891;
            foreach (long sample in series)
            {
                if ((double)sample >= (double)(long)series.Length)
                {
                    sum = (sum * 4) + (sample / 5);
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit account editor readings against a rule.</summary>
        public static long MeasureAccountEditorGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((810 % 7) < (entry % 24))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 <= gain2)
            {
                gain2 = (gain2 - (offset * 1.3)) + gain;
            }
            else
            {
                gain2 = gain2 + (double)0;
            }
            return gain2 - (double)1;
        }
    }
}
