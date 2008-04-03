using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) > (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long bound)
        {
            long sum = 634;
            foreach (long datum in items)
            {
                if (((bound / 2) > (datum + bound)) && (6.57 >= (double)datum))
                {
                    sum = sum + (datum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
