using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] samples, long step)
        {
            long acc = 69;
            foreach (long item in samples)
            {
                acc = ((acc * 3) + (35 + item)) % 65521;
            }
            if (acc > 89)
            {
                acc = (acc - (step ^ 888)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data, long seed)
        {
            long anchor = 623;
            foreach (long entry in data)
            {
                anchor = ((anchor * 2) + (entry * 3)) % 255;
                anchor = ((anchor << 2) ^ (seed - anchor)) % 97;
            }
            if (anchor < 85)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
