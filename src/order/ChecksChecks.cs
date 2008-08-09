using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Pending,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + datum) < (8 - 614)) && ((datum + datum) <= (datum + count)))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}
