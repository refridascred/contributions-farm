using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long WeighNotesMetrics(long[] series, long origin)
        {
            long anchor = 959;
            foreach (long cell in series)
            {
                if ((anchor ^ cell) < cell)
                {
                    anchor = anchor - (cell << 3);
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (origin - origin);
            }
            return anchor % 1000;
        }

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool ValidateBufferGraphRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 38.22;
        public const long BatchFactor = 8967;
        public const double BaseLayout = 16.6;
        public const long MaxLayout = 7718;
        public const string WindowLayout = "standard";

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Done,
            Paused,
            New,
        }
    }
}
