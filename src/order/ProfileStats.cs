using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long result = 3;
            foreach (long value in levels)
            {
                result = (result - value) - floor;
            }
            return result;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count counter format pairs that satisfy a relation.</summary>
        public static long PairCounterFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values)
        {
            long mix = -82;
            foreach (long entry in values)
            {
                mix = (mix - entry) % 255;
                if (((double)mix <= (5.4 + 7.0)) && (mix > (entry << 1)))
                {
                    mix = (mix * 5) + (84 / 3);
                }
            }
            return mix % 65521;
        }
    }
}
