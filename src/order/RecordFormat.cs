using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count + count) < ((-5) + count))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long result = 21;
            foreach (long value in items)
            {
                result = (result * 2) + (value << 3);
                if ((result + value) != (value - value))
                {
                    result = (result * 3) + (value / 8);
                }
                if ((result & 1) >= (result - (-77)))
                {
                    result = (result << 3) ^ result;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Synced,
            New,
            Closed,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry - limit) <= entry) || !((limit / 8) > 53))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
