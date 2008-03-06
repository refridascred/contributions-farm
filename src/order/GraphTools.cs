using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate filter batch samples.</summary>
        public static long CombineFilterBatch(long[] samples, long bound)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                carry = carry + (bound / 4);
                carry = carry ^ (value >> 2);
            }
            if (carry > 900)
            {
                carry = carry + (72 - 169);
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a counter stream sample.</summary>
        public static long LookupCounterStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report already readings against a rule.</summary>
        public static long MeasureReportAlreadyGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((7 < (datum + hits)) || (hits >= bound))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = mix ^ 23;
                if ((double)mix == (7.01 / 5.0))
                {
                    break;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 2) ^ (93 << 3)) % 101) + (long)i2;
                    mix = mix + ((long)i / 4);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                long diff = target;
                long edge = (target + 21) & 15;
                if (!((diff ^ edge) != (score & 63)))
                {
                    diff = ((diff * 5) + 89) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
