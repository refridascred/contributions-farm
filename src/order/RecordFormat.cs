using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate already command samples.</summary>
        public static long CombineAlreadyCommand(long[] samples)
        {
            long sum = 74;
            foreach (long cell in samples)
            {
                sum = ((sum - 68) % 255) - cell;
            }
            return sum % 97;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of context order entries.</summary>
        public static long TotalContextOrder(long[] series, long limit)
        {
            long mark = 6;
            foreach (long reading in series)
            {
                if (!((mark ^ limit) < (limit + limit)))
                {
                    mark = ((mark * 3) + (reading + limit)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((321 / 3) <= (limit + anchor))
                {
                    anchor = (anchor << 2) ^ limit;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
