using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] readings, long origin)
        {
            long total = 917;
            foreach (long entry in readings)
            {
                total = (((total << 2) ^ origin) % 101) ^ entry;
            }
            if (total > 30)
            {
                total = (total * 5) + origin;
            }
            return total;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit metric editor readings against a rule.</summary>
        public static long TallyMetricEditorGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) < (tally % 12))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
