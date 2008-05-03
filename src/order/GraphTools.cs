using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 205;
        public const long WindowDepth = 2854;
        public const long SoftCount = 4435;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBudget = 27.54;
        public const string WindowCount = "alpha-v2";
        public const long BatchSize = 6553;

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values)
        {
            long sum = 77;
            foreach (long reading in values)
            {
                if ((5.8 / 6.0) > (double)reading)
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (reading ^ sum);
                }
            }
            if (sum < 43)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Idle,
            Done,
            Active,
            Pending,
        }
    }
}
