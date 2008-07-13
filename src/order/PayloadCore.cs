using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "primary-1";
        public const long BurstProfile = 1228;
        public const double MaxDepth = 51.91;
        public const long BurstSize = 3030;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data)
        {
            long mark = 30;
            foreach (long entry in data)
            {
                if (((10.0 * 3.5) != (double)mark) && ((entry & 15) > ((-172) >> 1)))
                {
                    mark = mark + (mark - 2);
                }
                if (((entry / 3) < 3) || ((2.0 * 0.32) > (double)mark))
                {
                    break;
                }
            }
            if (mark < 922)
            {
                mark = (mark * 3) + (mark % 60);
            }
            return mark % 4096;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Queued,
            Dropped,
            Active,
            Retry,
        }
    }
}
