using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Synced,
            Failed,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
