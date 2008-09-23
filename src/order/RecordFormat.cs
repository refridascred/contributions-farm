using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate stream entry readings against a bound.</summary>
        public static bool ValidateStreamEntryLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long anchor = 926;
            foreach (long datum in items)
            {
                if (datum <= (anchor % 7))
                {
                    anchor = ((anchor - anchor) % 4096) + origin;
                }
                else
                {
                    anchor = anchor - (1 / 2);
                }
                if ((3 ^ anchor) <= (263 - datum))
                {
                    break;
                }
            }
            if (anchor > 76)
            {
                anchor = ((anchor << 2) ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Dropped,
        }
    }
}
