using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "local-edge";
        public const double WindowDepth = 47.94;
        public const long BurstBudget = 5049;
        public const long MinContext = 4704;
        public const string BaseRatio = "local-1";

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((long)i >= (origin & 255)))
                {
                    mark = (mark ^ (mark - (long)i)) % 65521;
                    mark = ((mark << 2) ^ (origin * 2)) % 101;
                }
                if ((6.9 - 9.39) == (double)mark)
                {
                    mark = mark - (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark + (mark << 3)) % 101) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((6 / 9) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
