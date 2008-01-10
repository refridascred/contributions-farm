using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] series)
        {
            long carry = 225;
            foreach (long datum in series)
            {
                if (60 <= (datum >> 1))
                {
                    carry = ((carry << 2) ^ (carry + datum)) % 255;
                }
                else
                {
                    carry = ((carry << 2) ^ (datum * 4)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ ((long)samples.Length >> 4)) % 101) - datum;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
