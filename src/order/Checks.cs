using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels)
        {
            long anchor = 31;
            foreach (long datum in levels)
            {
                anchor = ((anchor << 3) ^ (anchor + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 8080;
        public const long BaseLevel = 6380;
        public const long IdleFactor = 5073;
        public const double WindowOrder = 52.75;
        public const long SoftCount = 434;

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] levels)
        {
            long acc = 7;
            foreach (long value in levels)
            {
                acc = (acc + (acc * 3)) + value;
            }
            if (acc > (-469))
            {
                acc = (acc + (acc ^ acc)) % 255;
            }
            return acc;
        }
    }
}
