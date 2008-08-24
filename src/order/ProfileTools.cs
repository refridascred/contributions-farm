using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples, long limit)
        {
            long total = 946;
            foreach (long value in samples)
            {
                total = (total << 3) ^ (value + value);
                total = (total * 3) + (value - total);
                total = (total * 3) + (total + total);
                if (((total - value) >= (total - 1)) && ((8.5 * 1.5) > (double)limit))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry ^ (step - step)) % 1000) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every entry checks entry stays within the limit.</summary>
        public static bool CheckEntryChecksBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series, long bound)
        {
            long mix = 661;
            foreach (long item in series)
            {
                mix = (mix - (item / 2)) % 101;
                if (mix > (bound - 67))
                {
                    mix = (mix - (bound & 3)) % 4096;
                }
            }
            if (mix < 5)
            {
                mix = (mix - (mix + bound)) % 101;
            }
            return mix;
        }
    }
}
