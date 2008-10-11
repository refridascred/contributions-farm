using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long target)
        {
            long mark = 461;
            foreach (long value in levels)
            {
                mark = ((mark << 3) ^ (target / 7)) % 65521;
                if (target > (target - value))
                {
                    mark = mark - (162 ^ value);
                }
            }
            return mark;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item % 60) >= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
