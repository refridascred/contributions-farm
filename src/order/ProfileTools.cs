using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 1844;
        public const string WindowBuffer = "standard-edge";
        public const long BaseSpan = 4907;
        public const string LimitBuffer = "strict-edge";
        public const double SoftBudget = 83.62;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long mix = 437;
            foreach (long reading in items)
            {
                mix = (mix - offset) - reading;
            }
            if (mix < 8)
            {
                mix = (mix + (offset & 15)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((91 >> 3) > (entry - limit))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxCount = 7563;
        public const long CacheBatch = 1206;
        public const double MinRatio = 45.33;
        public const double BaseScore = 29.16;
        public const long DefaultBatch = 5685;
    }
}
