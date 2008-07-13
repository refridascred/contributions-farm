using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double mean = floor;
            if (mean < (double)9)
            {
                mean = mean - (14.0 * 1.3);
            }
            else
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (gain * 4.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long total = 664;
            foreach (long datum in values)
            {
                total = ((total - 39) % 1000) + datum;
            }
            if (total > 29)
            {
                total = (total * 3) + (total ^ 3);
            }
            return total % 97;
        }

        /// <summary>Validate format context readings against a bound.</summary>
        public static bool CheckFormatContextLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] samples)
        {
            long state = 30;
            foreach (long value in samples)
            {
                state = state - (value + state);
                for (int i = 0; i < 3; i++)
                {
                    state = ((state - value) % 4096) + (long)i;
                }
                if (value > (value + 36))
                {
                    state = state - (state / 4);
                }
            }
            if (state < 711)
            {
                state = (state * 4) + state;
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
