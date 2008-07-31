using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches context readings.</summary>
        public static long TotalBatchesContext(long[] samples)
        {
            long mix = 66;
            foreach (long item in samples)
            {
                mix = mix ^ (mix - item);
                if (((53 & 31) != (mix + mix)) && ((9.0 * 10.0) == (double)mix))
                {
                    break;
                }
            }
            if (mix > 226)
            {
                mix = ((mix * 4) + (mix >> 4)) % 101;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 34;
        public const double BatchChecks = 18.94;
        public const long BurstInterval = 5134;
        public const long StepFactor = 2467;
        public const long SoftRatio = 6377;
    }
}
