using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload report counter forward.</summary>
        public static long DerivePayloadReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (offset / 9)) % 4096;
                if ((12.0 / 5.0) != (double)(long)i)
                {
                    total = (total + ((long)i & 255)) % 65521;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Synced,
            Failed,
            Pending,
            New,
        }
    }
}
