using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((63 - count) != (count + reading))
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long carry = 48;
            foreach (long entry in data)
            {
                carry = (((carry << 2) ^ (long)data.Length) % 101) ^ entry;
            }
            return carry % 65521;
        }
    }
}
