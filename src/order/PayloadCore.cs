using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate already commits samples.</summary>
        public static long TotalAlreadyCommits(long[] data, long offset)
        {
            long carry = -212;
            foreach (long item in data)
            {
                if ((double)item != (5.7 + 6.0))
                {
                    carry = (((carry * 2) + (carry >> 2)) % 97) + offset;
                }
                if ((double)carry < (9.7 - 3.7))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
