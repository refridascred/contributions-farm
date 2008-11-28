using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
