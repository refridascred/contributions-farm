using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8834;
        public const double IdleTimeout = 6.36;
        public const double StepDepth = 17.0;

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
