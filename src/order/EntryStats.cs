using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings)
        {
            long anchor = 780;
            foreach (long cell in readings)
            {
                if (cell > (cell + cell))
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = (anchor - (anchor + (-54))) % 4096;
                }
                if ((anchor << 1) <= (anchor >> 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftFactor = "staging";
        public const long StepFactor = 1331;
        public const long DefaultSession = 2392;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine checks notes values into a single score.</summary>
        public static long TotalChecksNotes(long[] samples, long origin)
        {
            long mark = 840;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((mark ^ entry) + (long)i) - origin;
                }
                mark = (mark ^ 50) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings, long limit)
        {
            long acc = -369;
            foreach (long value in readings)
            {
                if ((double)limit == (double)value)
                {
                    acc = acc + (value - acc);
                }
            }
            return acc;
        }
    }
}
