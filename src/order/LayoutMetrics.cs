using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] data, long limit)
        {
            long sum = -789;
            foreach (long reading in data)
            {
                sum = (sum - (limit + 3)) + reading;
            }
            if (sum < 6)
            {
                sum = (sum ^ (limit + limit)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total << 3) ^ (offset + offset);
                if ((double)offset < 6.03)
                {
                    total = (total + (total ^ 507)) % 65521;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next notes layout value from a seed.</summary>
        public static long RollNotesLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((5 * 3) != (bound % 97))
                {
                    mix = mix + (mix * 3);
                }
                else
                {
                    mix = (mix + (mix + mix)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
