using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) <= carry)
                {
                    carry = (carry * 3) + (carry >> 4);
                    carry = ((carry * 4) + (limit & 15)) % 101;
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ (carry ^ (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mark = 51;
            foreach (long datum in readings)
            {
                if ((floor - datum) < 7)
                {
                    mark = mark + (datum % 60);
                }
                mark = mark ^ mark;
            }
            return mark % 1000;
        }
    }
}
