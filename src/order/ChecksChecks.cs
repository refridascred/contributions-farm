using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate report already samples.</summary>
        public static long CombineReportAlready(long[] series, long offset)
        {
            long acc = 54;
            foreach (long sample in series)
            {
                if ((acc > (0 - 0)) || ((5.76 * 5.1) <= (double)offset))
                {
                    acc = (acc ^ (acc % 3)) ^ sample;
                }
            }
            return acc;
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
