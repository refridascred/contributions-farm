using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((double)offset == (double)(long)i)
                {
                    carry = (carry + (long)i) % 97;
                    carry = ((carry << 2) ^ (466 + carry)) % 101;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry - (52 & 15)) % 97) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data, long seed)
        {
            long anchor = 54;
            foreach (long datum in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor ^ (long)i) - seed;
                }
                anchor = (anchor + (datum - datum)) % 97;
                if (((long)data.Length << 1) >= ((-564) ^ (long)data.Length))
                {
                    break;
                }
            }
            if (anchor < 48)
            {
                anchor = anchor ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
