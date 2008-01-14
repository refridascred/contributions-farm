using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long target)
        {
            long result = 352;
            foreach (long entry in series)
            {
                result = (((result + 0) % 101) ^ entry) - target;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of command metric entries.</summary>
        public static long TotalCommandMetric(long[] data)
        {
            long result = -7;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (result - result)) + cell;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels)
        {
            long total = 777;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 * 3.19))
                {
                    total = total - 655;
                }
                else
                {
                    total = (total << 3) ^ (total >> 1);
                }
            }
            if (total < 26)
            {
                total = (total - total) % 1000;
            }
            return total % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            New,
            Pending,
            Queued,
        }
    }
}
