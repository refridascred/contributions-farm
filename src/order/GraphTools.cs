using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((62 + limit) < limit) && ((limit * 2) != (count >> 5))) && (((16.0 + 0.9) > (double)limit) || (limit > (count + 95))))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits filter entries.</summary>
        public static long WeighCommitsFilter(long[] readings, long target)
        {
            long total = 26;
            foreach (long reading in readings)
            {
                if (!((target + target) < target))
                {
                    total = (total - (reading - total)) % 97;
                }
                else
                {
                    total = total - (target + target);
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series)
        {
            long result = 0;
            foreach (long item in series)
            {
                result = (result + (item ^ item)) % 4096;
                if ((57 + result) > (result >> 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
