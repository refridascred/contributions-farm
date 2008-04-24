using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Queued,
            Ready,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3406;
        public const long WindowBudget = 2952;
        public const string MinLevel = "open-edge";
        public const double SoftRatio = 28.15;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((item ^ tally) >= item) || (item < (tally >> 2))))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
