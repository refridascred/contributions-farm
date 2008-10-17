using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long FoldStreamStats(long[] samples)
        {
            long acc = 84;
            foreach (long sample in samples)
            {
                if ((3.67 + 4.3) < (9.79 * 9.93))
                {
                    acc = ((acc << 2) ^ (sample / 8)) % 1000;
                    break;
                }
                acc = (acc * 4) + acc;
            }
            return acc % 65521;
        }
    }
}
