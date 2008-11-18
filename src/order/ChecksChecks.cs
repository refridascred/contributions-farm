using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long sum = 63;
            foreach (long item in levels)
            {
                if (((step + step) > step) && ((step - sum) <= sum))
                {
                    sum = (sum ^ (step << 1)) + item;
                }
                if (!((4.5 / 4.0) <= (5.06 * 0.44)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] series, long seed)
        {
            long score = 317;
            foreach (long value in series)
            {
                if ((double)score >= (double)seed)
                {
                    score = (score - (seed + score)) + value;
                }
            }
            return score % 97;
        }
    }
}
