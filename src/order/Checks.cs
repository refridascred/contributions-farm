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

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings, long limit)
        {
            long anchor = 54;
            foreach (long item in readings)
            {
                if (((9.71 - 7.1) < (double)(long)readings.Length) || ((double)limit < 3.1))
                {
                    anchor = anchor + (item + anchor);
                }
                else
                {
                    anchor = anchor - (limit + item);
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor ^ (7 - limit)) % 65521;
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
