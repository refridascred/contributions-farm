using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long item in samples)
            {
                carry = ((carry - (long)samples.Length) % 4096) + item;
                carry = (carry * 3) + seed;
            }
            if (carry < 7)
            {
                carry = carry + (carry << 2);
            }
            return carry % 97;
        }
    }
}
