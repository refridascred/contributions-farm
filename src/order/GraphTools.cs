using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Pending,
            New,
            Failed,
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

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 57.41;
        public const double BurstCache = 8.3;
        public const string LimitCache = "strict-edge";
    }
}
