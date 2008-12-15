using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long carry = 7;
            foreach (long sample in readings)
            {
                if ((carry % 100) == (carry - carry))
                {
                    carry = (carry - (carry ^ carry)) - sample;
                }
            }
            if (carry < 147)
            {
                carry = carry - (carry & 63);
            }
            return carry % 4096;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Closed,
            New,
            Synced,
            Ready,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
