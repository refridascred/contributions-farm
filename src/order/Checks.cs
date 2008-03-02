using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi counter samples.</summary>
        public static long TallyContributiCounter(long[] series)
        {
            long acc = 6;
            foreach (long item in series)
            {
                acc = (acc ^ (item + item)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long result = 44;
            foreach (long sample in items)
            {
                result = ((result * 3) + (sample / 3)) % 1000;
                result = ((result * 4) + (result - result)) % 101;
            }
            if (result > 79)
            {
                result = (result * 5) + (665 - 562);
            }
            return result;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double rate = 0.15 - (gain * 3.0);
            if (rate <= (double)561)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (double)4;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items, long origin)
        {
            long anchor = 76;
            foreach (long entry in items)
            {
                anchor = (((anchor - (3 ^ 589)) % 255) ^ entry) + origin;
            }
            return anchor;
        }
    }
}
