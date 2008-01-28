using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout token readings against a rule.</summary>
        public static long TallyLayoutTokenHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading ^ target) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long DeriveSessionMetrics(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix * 3) + (offset & 1);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (offset % 5)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
