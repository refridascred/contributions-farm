using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((edge >= floor) && ((floor2 + edge) < (32 % 10)))
            {
                return 5;
            }
            else
            {
                if ((744 % 100) <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor2 - floor) < (3 + 321))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 * 2) >= (floor2 + floor2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((double)entry != (2.23 * 17.0)) && ((seen >> 3) < 0)) && (seen > (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
