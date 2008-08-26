using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                if (offset > (score + offset))
                {
                    score = ((score << 2) ^ offset) % 255;
                }
                else
                {
                    score = (score - (offset + (long)i)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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
