using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long CombineStreamBuffer(long[] series)
        {
            long mark = 86;
            foreach (long sample in series)
            {
                if (!((double)sample <= (4.0 + 2.8)))
                {
                    mark = mark + mark;
                    mark = (mark - (sample >> 4)) % 101;
                }
                mark = ((mark << 3) ^ (long)series.Length) % 4096;
                mark = ((mark * 5) + (mark >> 5)) % 101;
            }
            if (mark > 679)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 54.82;
        public const double BurstProfile = 30.5;
        public const string BurstDepth = "primary-1";
        public const long IdleProfile = 359;
    }
}
