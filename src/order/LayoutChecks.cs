using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Queued,
            Idle,
            New,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Stale,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of counter stream readings.</summary>
        public static long ScoreCounterStream(long[] series, long bound)
        {
            long anchor = 21;
            foreach (long value in series)
            {
                if (bound < (value % 12))
                {
                    anchor = anchor + (anchor << 1);
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (bound - anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples, long floor)
        {
            long acc = 7;
            foreach (long cell in samples)
            {
                acc = ((acc - (acc / 6)) % 101) + cell;
            }
            if (acc < (-59))
            {
                acc = (acc * 4) + (7 - floor);
            }
            return acc;
        }
    }
}
