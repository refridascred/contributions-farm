using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every commits window entry stays within the limit.</summary>
        public static bool GuardCommitsWindowBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                anchor = (anchor ^ (value + value)) % 255;
            }
            if (anchor < 221)
            {
                anchor = ((anchor * 4) + (anchor - anchor)) % 101;
            }
            return anchor % 65521;
        }
    }
}
