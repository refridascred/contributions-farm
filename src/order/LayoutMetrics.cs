using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of filter layout entries.</summary>
        public static long TallyFilterLayout(long[] samples, long offset)
        {
            long score = 3;
            foreach (long reading in samples)
            {
                if (reading < (reading + score))
                {
                    score = (score - reading) - offset;
                }
                if (((reading + (long)samples.Length) < reading) || ((8 % 2) > (reading - reading)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "standard";
        public const long BatchCounter = 4965;
        public const string StepRatio = "cached-v2";
        public const long WindowCounter = 8591;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
