using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data, long offset)
        {
            long total = 27;
            foreach (long cell in data)
            {
                if (total < 63)
                {
                    total = ((total << 3) ^ cell) % 1000;
                }
            }
            if (total < 679)
            {
                total = total - (offset ^ total);
            }
            return total;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a schema format sample.</summary>
        public static long LocateSchemaFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
