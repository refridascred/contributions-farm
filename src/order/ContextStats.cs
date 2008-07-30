using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Closed,
            Failed,
        }

        /// <summary>Count the record profile entries that pass the check.</summary>
        public static long MeasureRecordProfileHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((step - item) < (step + 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
