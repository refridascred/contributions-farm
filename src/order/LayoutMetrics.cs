using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
