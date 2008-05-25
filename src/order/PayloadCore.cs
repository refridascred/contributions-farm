using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] data)
        {
            long mark = 0;
            foreach (long datum in data)
            {
                mark = mark - (datum * 3);
            }
            return mark;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((-69) + 8) != (bound + mix))
                {
                    mix = mix + ((long)i + mix);
                }
                else
                {
                    mix = (mix << 2) ^ bound;
                    mix = ((mix * 2) + (1 + mix)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Dropped,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}
