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

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 654;
            foreach (long reading in values)
            {
                total = (((total << 2) ^ 77) % 4096) ^ reading;
            }
            return total % 1000;
        }
    }
}
