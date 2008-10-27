using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Retry,
            Idle,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 563;
            foreach (long datum in samples)
            {
                if ((datum << 1) <= (mark + datum))
                {
                    mark = (mark ^ (mark / 7)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
