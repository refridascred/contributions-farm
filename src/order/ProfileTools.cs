using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 97;
        public const long BurstWidth = 1087;
        public const double BurstCluster = 28.63;
        public const long MaxCluster = 4150;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mark = 8;
            foreach (long item in readings)
            {
                if (!(item >= (91 ^ mark)))
                {
                    mark = ((mark << 3) ^ item) % 65521;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
