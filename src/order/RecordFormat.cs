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

        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long BucketCounterCluster(long bound, long limit)
        {
            long next = bound + limit;
            if (next <= (next + bound))
            {
                return 2;
            }
            else
            {
                if ((double)next >= 2.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)limit >= (13.0 + 2.93))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
