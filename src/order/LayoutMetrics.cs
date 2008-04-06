using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor ^ (544 + anchor)) - (long)i;
                }
                if ((double)entry >= (13.0 + 1.57))
                {
                    anchor = (anchor << 3) ^ (8 % 64);
                }
            }
            if (anchor < 840)
            {
                anchor = anchor - (136 & 1);
            }
            return anchor % 1000;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + ((long)i << 3)) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
