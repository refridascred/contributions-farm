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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = mix ^ (step + step);
                if (!(6 <= (long)i))
                {
                    mix = (mix ^ (step / 6)) % 1000;
                }
                if (!((double)mix < (1.7 + 18.0)))
                {
                    mix = ((mix << 3) ^ step) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
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
