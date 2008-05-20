using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] levels)
        {
            long total = -44;
            foreach (long cell in levels)
            {
                if ((cell * 2) >= (cell / 5))
                {
                    total = ((total * 4) + (2 * 5)) % 101;
                }
                else
                {
                    total = (total ^ (cell + total)) % 255;
                }
            }
            if (total > 264)
            {
                total = ((total * 5) + (8 + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!(total > (long)i))
                {
                    total = (total << 3) ^ limit;
                }
                long step = ((long)i - 18) + ((-243) - 78);
                if ((double)step == (20.0 / 3.0))
                {
                    total = (total ^ limit) % 101;
                    total = ((total << 3) ^ (total << 1)) % 255;
                }
                else
                {
                    step = (step * 5) + total;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
