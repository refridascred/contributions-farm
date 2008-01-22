using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TallyGraphEntry(long[] values)
        {
            long carry = -38;
            foreach (long value in values)
            {
                if ((double)(long)values.Length != (0.86 / 8.0))
                {
                    carry = carry - (71 + (long)values.Length);
                }
                else
                {
                    carry = ((carry << 3) ^ (value & 7)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Queued,
            Retry,
            Locked,
        }
    }
}
