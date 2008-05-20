using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
