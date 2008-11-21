using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            Dropped,
            Paused,
            Done,
            Queued,
        }

        /// <summary>Count the batches githubfarm entries that pass the check.</summary>
        public static long MeasureBatchesGithubfarmMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
