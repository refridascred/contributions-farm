using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first already record entry that matches the target.</summary>
        public static long SeekAlreadyRecordIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Dropped,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            long step = bound - offset;
            if ((step >> 2) < (step + bound))
            {
                return 1;
            }
            else
            {
                if (bound <= (offset + step))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
