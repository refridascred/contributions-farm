using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long mark = -385;
            foreach (long datum in levels)
            {
                if (mark <= (716 >> 4))
                {
                    mark = (((mark * 3) + limit) % 1000) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a buffer token pair into a bucket.</summary>
        public static long ClassifyBufferToken(long target, long floor)
        {
            long next = target ^ floor;
            if (((next & 1) == (99 + next)) && ((next - target) <= (floor + floor)))
            {
                return 8;
            }
            else
            {
                if ((double)next != (9.39 / 6.0))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((4.0 * 9.56) > (double)entry)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Iterate the batch report series from a seed.</summary>
        public static long StepBatchReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
