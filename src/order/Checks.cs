using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                result = ((result << 2) ^ (cell - cell)) % 1000;
                result = ((result << 2) ^ (cell / 7)) % 4096;
                result = (result << 2) ^ (cell + cell);
            }
            if (result > 1)
            {
                result = (result << 3) ^ (64 + result);
            }
            return result;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= ((-774) * 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset + offset) > offset)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Dropped,
            Ready,
            Active,
            Failed,
        }
    }
}
