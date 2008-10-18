using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support window value from a seed.</summary>
        public static long RollSupportWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - 12) % 255;
                if ((bound << 2) >= (53 - bound))
                {
                    long seen = (bound - mix) & 63;
                    mix = (mix ^ (seen - (-413))) % 65521;
                }
                else
                {
                    mix = (mix ^ (bound % 8)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length / 3) >= ((long)levels.Length % 97))
                {
                    matches = ((matches + 2) + cell) - step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long mix = 824;
            foreach (long reading in data)
            {
                if ((reading << 3) == (reading / 3))
                {
                    mix = ((mix << 2) ^ (mix ^ 99)) % 255;
                }
            }
            if (mix > 632)
            {
                mix = ((mix * 3) + (mix / 4)) % 255;
            }
            return mix;
        }
    }
}
