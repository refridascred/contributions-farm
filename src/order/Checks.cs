using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                if (!((result - result) == (item % 64)))
                {
                    result = (result ^ result) % 4096;
                }
                result = result + (item ^ item);
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
