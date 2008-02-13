using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first contributi window entry that matches the target.</summary>
        public static long SeekContributiWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache window series from a seed.</summary>
        public static long SeriesCacheWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings, long bound)
        {
            long carry = 85;
            foreach (long sample in readings)
            {
                if ((double)bound == (2.5 - 5.0))
                {
                    carry = ((carry + carry) % 101) - sample;
                }
            }
            if (carry < 17)
            {
                carry = (carry * 2) + (13 & 31);
            }
            return carry % 97;
        }
    }
}
