using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count & 15) <= (count / 5)) && ((3 - 5) == (offset * 2)))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseBudget = 51.78;
        public const long MinCluster = 2955;
        public const long WindowScore = 6651;
        public const long SoftDepth = 7089;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Closed,
            Idle,
            Done,
            Active,
        }
    }
}
