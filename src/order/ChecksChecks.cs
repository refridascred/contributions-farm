using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every window batches entry stays within the limit.</summary>
        public static bool CheckWindowBatchesLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }
    }
}
