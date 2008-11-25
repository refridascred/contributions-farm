using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i ^ anchor) > target))
                {
                    anchor = anchor + target;
                }
                anchor = anchor - target;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of buffer queue entries.</summary>
        public static long DigestBufferQueue(long[] readings)
        {
            long carry = 57;
            foreach (long item in readings)
            {
                if ((item * 4) > carry)
                {
                    carry = ((carry * 5) + carry) % 97;
                }
                else
                {
                    carry = carry ^ item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
