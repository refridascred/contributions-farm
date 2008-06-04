using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a queue route counter forward.</summary>
        public static long DeriveQueueRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((mark - offset) < ((long)i + (long)i)) || ((double)(long)i < (5.28 / 7.0)))
                {
                    mark = (mark * 5) + ((long)i >> 2);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitFactor = 5823;
        public const long BaseWidth = 5534;
        public const long BurstRatio = 6257;
        public const long DefaultRoute = 183;
        public const long LimitInterval = 9291;
    }
}
