using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window order readings.</summary>
        public static long FoldWindowOrder(long[] series)
        {
            long total = 30;
            foreach (long sample in series)
            {
                if ((total - 535) != (22 % 7))
                {
                    total = ((total + total) % 65521) - sample;
                }
            }
            return total;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Closed,
            Done,
        }
    }
}
