using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long seed)
        {
            long anchor = -69;
            foreach (long sample in data)
            {
                if ((seed ^ anchor) >= (seed / 6))
                {
                    anchor = (anchor ^ sample) % 65521;
                }
                if ((double)seed <= (4.06 / 6.0))
                {
                    anchor = anchor + (sample % 24);
                    anchor = (anchor << 3) ^ (seed ^ seed);
                }
                anchor = (anchor - (sample << 2)) % 65521;
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor + 0)) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of command stream readings.</summary>
        public static long CombineCommandStream(long[] series)
        {
            long sum = 205;
            foreach (long sample in series)
            {
                sum = (sum << 2) ^ (sample - sample);
            }
            if (sum < 0)
            {
                sum = ((sum * 3) + (sum / 3)) % 255;
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
