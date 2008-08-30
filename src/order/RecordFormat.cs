using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long target, long limit)
        {
            if (!((4.0 / 6.0) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((double)target != (8.2 * 1.5))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long offset)
        {
            long sum = 652;
            foreach (long entry in data)
            {
                if ((entry & 127) < offset)
                {
                    sum = ((sum << 3) ^ (sum & 1)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (offset * 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= 2)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
