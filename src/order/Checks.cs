using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 93.47;
        public const long IdleCount = 5934;
        public const long WindowDepth = 4566;

        /// <summary>Find the first entry record entry that matches the target.</summary>
        public static long SeekEntryRecordIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data, long limit)
        {
            long acc = 93;
            foreach (long reading in data)
            {
                if ((limit - reading) == (limit / 5))
                {
                    acc = ((acc * 4) + 5) % 4096;
                }
                else
                {
                    acc = (acc ^ (reading / 2)) % 255;
                }
                if (((acc & 63) != (limit / 7)) && ((reading + acc) <= reading))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Done,
            Queued,
            New,
        }
    }
}
