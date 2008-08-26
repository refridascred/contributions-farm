using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = total + (bound * 4);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Locked,
            Closed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long offset)
        {
            long mix = -832;
            foreach (long item in samples)
            {
                if (((offset % 2) > mix) || ((14.0 + 3.8) >= (double)offset))
                {
                    mix = (mix ^ (mix << 1)) - item;
                }
                else
                {
                    mix = (mix - (offset / 9)) % 97;
                }
            }
            if (mix > 13)
            {
                mix = mix + (mix - offset);
            }
            return mix;
        }
    }
}
