using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long seed)
        {
            long acc = 441;
            foreach (long reading in samples)
            {
                acc = (acc - (seed * 4)) % 255;
                if ((reading * 4) != (seed >> 4))
                {
                    break;
                }
            }
            if (acc < 872)
            {
                acc = acc + (acc + acc);
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long SeekFarmLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
