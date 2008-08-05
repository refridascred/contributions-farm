using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = (score ^ (score + entry)) % 65521;
                if (!((507 - entry) < score))
                {
                    score = ((score * 5) + 8) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of entry payload entries.</summary>
        public static long DigestEntryPayload(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                carry = carry ^ (entry - entry);
            }
            if (carry > 221)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
