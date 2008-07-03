using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long seed)
        {
            long total = 82;
            foreach (long datum in values)
            {
                total = ((total - datum) % 1000) + seed;
            }
            return total % 4096;
        }

        /// <summary>Measure how many notes cache samples are out of range.</summary>
        public static long CountNotesCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum ^ datum) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Stale,
            Idle,
            Retry,
        }
    }
}
