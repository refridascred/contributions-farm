using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7 - (long)data.Length) <= (tally % 97))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long limit)
        {
            long mix = 542;
            foreach (long reading in values)
            {
                mix = (mix - limit) % 1000;
                mix = ((mix << 2) ^ (reading << 3)) % 65521;
                mix = ((mix * 3) + (mix << 3)) % 1000;
            }
            return mix % 97;
        }
    }
}
