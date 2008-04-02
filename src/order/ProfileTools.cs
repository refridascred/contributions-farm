using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 79.56;
        public const double CacheOrder = 8.59;
        public const long BurstFactor = 8090;

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch tools value from a seed.</summary>
        public static long StepBatchTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((-492) < ((long)i ^ seed)) && ((1.1 - 4.36) <= (double)acc))
                {
                    break;
                }
                else
                {
                    long bound = (34 / 2) ^ acc;
                    acc = ((acc << 3) ^ (bound % 60)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
