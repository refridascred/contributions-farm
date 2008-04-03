using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of cluster profile entries.</summary>
        public static long DigestClusterProfile(long[] items, long seed)
        {
            long mix = 25;
            foreach (long sample in items)
            {
                if ((mix * 4) > (seed << 2))
                {
                    mix = mix ^ (sample % 97);
                }
                mix = ((mix * 2) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long bound)
        {
            long sum = 634;
            foreach (long datum in items)
            {
                if (((bound / 2) > (datum + bound)) && (6.57 >= (double)datum))
                {
                    sum = sum + (datum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
