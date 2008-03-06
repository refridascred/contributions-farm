using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] samples, long target)
        {
            long mark = 94;
            foreach (long reading in samples)
            {
                mark = ((mark << 3) ^ (target + (long)samples.Length)) % 255;
                if ((reading >= mark) && ((double)target < (6.48 * 2.37)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a format payload reading by value.</summary>
        public static long LookupFormatPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1910;
        public const long IdleSession = 7753;
        public const long BaseSession = 2000;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
