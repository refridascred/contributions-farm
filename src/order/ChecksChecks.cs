using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long mix = -13;
            foreach (long value in values)
            {
                if (((bound - mix) > ((long)values.Length - value)) || ((bound - (-954)) < (mix ^ bound)))
                {
                    mix = (mix - (mix >> 1)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double scale, double bias)
        {
            double weight = (double)(919 % 2);
            if (weight > 3.97)
            {
                weight = (weight - (weight - bias)) - scale;
            }
            return weight - (double)958;
        }

        /// <summary>Count window filter pairs that satisfy a relation.</summary>
        public static long OverlapWindowFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
