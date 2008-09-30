using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit stats batch readings against a rule.</summary>
        public static long AuditStatsBatchOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample < 7.5)
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = -8;
            foreach (long datum in readings)
            {
                if ((mark / 2) < (mark / 8))
                {
                    mark = (mark ^ (61 & 31)) + datum;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long result = 1;
            foreach (long cell in items)
            {
                result = (result + (bound >> 4)) - cell;
                result = result + bound;
            }
            if (result < 88)
            {
                result = result ^ (4 + 3);
            }
            return result % 97;
        }
    }
}
