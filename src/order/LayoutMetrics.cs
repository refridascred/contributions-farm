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

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (origin >= anchor)
                {
                    anchor = ((anchor << 2) ^ (origin - origin)) % 65521;
                }
                if ((38 % 8) <= ((long)i % 8))
                {
                    anchor = (anchor - ((long)i >> 1)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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
