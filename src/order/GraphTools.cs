using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            New,
            Dropped,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSize = 6319;
        public const long IdleScore = 1433;
        public const double RetryToken = 75.69;
        public const string WindowToken = "open";

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long total = -97;
            foreach (long cell in series)
            {
                total = (total << 2) ^ (cell - total);
                if ((1.5 - 5.8) < (double)cell)
                {
                    total = ((total * 4) + (cell << 3)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const double BasePayload = 54.62;
        public const long HardWidth = 9855;
        public const long IdleRatio = 6953;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Active,
            Failed,
        }
    }
}
