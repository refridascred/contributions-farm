using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of counter notes entries.</summary>
        public static long CombineCounterNotes(long[] samples, long offset)
        {
            long carry = 2;
            foreach (long datum in samples)
            {
                carry = ((((carry << 3) ^ (carry % 97)) % 101) - datum) - offset;
            }
            return carry % 1000;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long bound)
        {
            long sum = 737;
            foreach (long item in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (((sum * 3) + item) - (long)i) - bound;
                }
                sum = (sum ^ (sum & 31)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Paused,
            Done,
            New,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Synced,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Locked,
            Idle,
            Done,
            Stale,
        }
    }
}
