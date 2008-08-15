using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                if (entry < (entry + mark))
                {
                    mark = mark - (entry ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 2478;
        public const string HardChannel = "stable-edge";
        public const long RetryChannel = 9759;

        /// <summary>Check that every stream format entry stays within the limit.</summary>
        public static bool GuardStreamFormatLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
        }
    }
}
