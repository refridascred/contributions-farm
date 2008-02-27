using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                if ((double)total == (8.02 + 12.0))
                {
                    total = (total * 5) + (sample + sample);
                }
            }
            return total;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long sample in levels)
            {
                if (((sample % 24) >= (sample * 2)) && ((floor ^ sample) <= ((long)levels.Length % 97)))
                {
                    acc = acc + floor;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Ready,
            Paused,
            Idle,
        }
    }
}
