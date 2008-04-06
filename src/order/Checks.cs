using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 56.36;
        public const long LimitInterval = 9850;
        public const long DefaultBatches = 1989;
        public const long MinBatches = 7467;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Failed,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Accumulate window batch samples.</summary>
        public static long CombineWindowBatch(long[] values)
        {
            long anchor = 957;
            foreach (long sample in values)
            {
                if ((sample > anchor) && ((257 * 5) <= (anchor - sample)))
                {
                    anchor = (anchor - (sample / 2)) % 97;
                }
                else
                {
                    anchor = anchor ^ (anchor - sample);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "local";
        public const long BaseProfile = 4739;
        public const string WindowProfile = "cached-v2";
        public const string BurstRatio = "primary-1";
    }
}
