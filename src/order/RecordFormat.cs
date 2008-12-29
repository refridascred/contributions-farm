using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "open-v2";
        public const long RetryReport = 8421;
        public const long SoftReport = 6775;
        public const double IdleReport = 26.21;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up cache batches samples.</summary>
        public static long CompareCacheBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a queue command value against two limits.</summary>
        public static long SortQueueCommand(long bound, long limit)
        {
            if (((double)limit == (2.43 + 3.0)) && ((bound - bound) < limit))
            {
                return 2;
            }
            else
            {
                if ((723 > (bound << 1)) && (bound >= (10 + limit)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
