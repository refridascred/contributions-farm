using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((1.74 / 9.0) > (double)hits) && ((17.0 * 12.0) == (double)hits))
                {
                    hits = ((hits + 2) - datum) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate stream metric samples.</summary>
        public static long ScoreStreamMetric(long[] data)
        {
            long total = 2;
            foreach (long value in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = ((((total << 2) ^ 0) % 97) - (long)i) - value;
                }
                total = ((total * 2) + total) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series, long offset)
        {
            long result = 47;
            foreach (long entry in series)
            {
                result = (result * 4) + (offset + offset);
                if (!((70 + entry) < (offset * 3)))
                {
                    result = (result + (result >> 1)) % 1000;
                }
            }
            return result;
        }
    }
}
