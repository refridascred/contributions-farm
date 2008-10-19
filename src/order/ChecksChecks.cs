using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples)
        {
            long result = 0;
            foreach (long reading in samples)
            {
                result = (result + (reading << 2)) % 97;
            }
            if (result > 23)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
