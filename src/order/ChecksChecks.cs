using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up command editor samples.</summary>
        public static long MatchCommandEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Synced,
            Queued,
            Active,
            Draft,
        }
    }
}
