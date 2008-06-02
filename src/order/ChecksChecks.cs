using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mix = 502;
            foreach (long item in levels)
            {
                if ((7 >> 5) >= item)
                {
                    mix = (mix * 3) + (long)levels.Length;
                }
                if ((mix * 5) == (item - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two order window measurements.</summary>
        public static double SmoothOrderWindow(double ratio, double bias)
        {
            double weight = (ratio + ratio) + bias;
            if (weight <= ratio)
            {
                weight = weight - 8.69;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (bound ^ anchor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
