using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long AuditNotesFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally == (5.3 + 8.51))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of window commits readings.</summary>
        public static long CombineWindowCommits(long[] items)
        {
            long total = 55;
            foreach (long cell in items)
            {
                if ((cell >> 2) == (cell << 3))
                {
                    total = (total ^ (cell + total)) % 1000;
                }
            }
            if (total > 333)
            {
                total = (total * 2) + (total + total);
            }
            return total % 1000;
        }
    }
}
