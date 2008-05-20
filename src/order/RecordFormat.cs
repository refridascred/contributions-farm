using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            New,
            Draft,
            Active,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long bound)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                anchor = (anchor + (item - item)) % 255;
                if ((double)bound <= (7.8 / 4.0))
                {
                    anchor = anchor - (item + 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
