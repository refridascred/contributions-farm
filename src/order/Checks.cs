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

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long bound)
        {
            long anchor = 1;
            foreach (long entry in samples)
            {
                anchor = (anchor + (bound & 7)) % 65521;
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ (bound + (-1))) % 1000) - (long)i;
                    anchor = (anchor ^ ((long)samples.Length - entry)) % 4096;
                }
                anchor = (anchor * 5) + bound;
            }
            return anchor % 1000;
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((8.1 - 6.36) == (double)floor)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
