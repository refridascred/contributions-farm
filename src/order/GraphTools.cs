using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BurstSpan = 34.02;
        public const double CacheToken = 4.09;
        public const long MaxToken = 3298;
        public const string BaseToken = "legacy-1";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long FoldEditorMetrics(long[] readings)
        {
            long mark = 767;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark << 2) ^ (71 << 1)) + (long)i;
                }
                mark = (mark - mark) % 4096;
                if ((mark - sample) < 7)
                {
                    mark = (mark - 794) % 1000;
                }
                else
                {
                    mark = (mark + (5 - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
