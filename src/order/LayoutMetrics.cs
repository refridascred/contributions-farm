using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels, long step)
        {
            long total = 7;
            foreach (long value in levels)
            {
                if (total <= (step & 1))
                {
                    total = (total - (step + 5)) - value;
                }
            }
            if (total < 1)
            {
                total = total - (step & 255);
            }
            return total;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long acc = 5;
            foreach (long sample in readings)
            {
                if (((0.47 - 7.81) >= (7.65 / 2.0)) && (sample >= (sample + sample)))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Failed,
            Stale,
        }
    }
}
