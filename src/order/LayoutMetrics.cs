using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of githubfarm schema readings.</summary>
        public static long CompareGithubfarmSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
