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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
