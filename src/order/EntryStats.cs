using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (-227)) % 1000;
                anchor = (anchor ^ offset) % 97;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((floor - result) >= floor)
                {
                    result = (result + (result & 1)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Queued,
            Stale,
            Synced,
            Failed,
            New,
        }
    }
}
