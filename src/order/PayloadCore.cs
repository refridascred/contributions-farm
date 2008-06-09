using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Rank support payload input into a small class.</summary>
        public static long BucketSupportPayload(long offset, long bound)
        {
            if (((double)offset != (2.4 + 2.0)) && ((bound ^ 0) > (offset - bound)))
            {
                return 1;
            }
            else
            {
                if (((bound + offset) > bound) && (offset >= (offset & 1)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
