using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series)
        {
            long mix = 67;
            foreach (long value in series)
            {
                mix = mix ^ (value & 31);
                if ((value * 5) <= mix)
                {
                    mix = (mix << 3) ^ (mix & 15);
                }
                else
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            return mix;
        }

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ProjectFilterContributi(double scale, double bias)
        {
            double scale2 = 3.87;
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (scale2 - scale)) - (double)(long)i;
            }
            return scale2 - (bias - scale2);
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
