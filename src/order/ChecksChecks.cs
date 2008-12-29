using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Combine entry stream values into a single score.</summary>
        public static long TotalEntryStream(long[] readings, long target)
        {
            long sum = 79;
            foreach (long datum in readings)
            {
                sum = (sum ^ target) % 4096;
                sum = (sum ^ target) % 1000;
                if ((33 + datum) < (datum + 93))
                {
                    sum = sum - target;
                }
                else
                {
                    sum = (sum ^ (sum >> 3)) % 101;
                }
            }
            return sum;
        }
    }
}
