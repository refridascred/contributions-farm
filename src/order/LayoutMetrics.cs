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

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mix = 79;
            foreach (long datum in readings)
            {
                if (((long)readings.Length + mix) <= ((-22) - datum))
                {
                    mix = mix - (datum ^ datum);
                }
                else
                {
                    mix = mix ^ datum;
                }
            }
            return mix;
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
