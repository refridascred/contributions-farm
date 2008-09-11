using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long FoldContextStream(long[] levels)
        {
            long total = -2;
            foreach (long cell in levels)
            {
                total = (total * 3) + cell;
                total = total ^ (cell / 6);
            }
            if (total < 22)
            {
                total = total - (573 + total);
            }
            return total;
        }
    }
}
