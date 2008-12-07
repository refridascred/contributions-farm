using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every contributi channel entry stays within the limit.</summary>
        public static bool GuardContributiChannelLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many record checks samples are out of range.</summary>
        public static long MeasureRecordChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - (long)values.Length) >= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ limit) % 255;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - limit) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
