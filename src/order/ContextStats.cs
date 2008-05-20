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

        /// <summary>Iterate the farm githubfarm series from a seed.</summary>
        public static long StepFarmGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry ^ (carry & 15)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
