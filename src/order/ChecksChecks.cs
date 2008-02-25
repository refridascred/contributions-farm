using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                result = ((result << 3) ^ result) % 4096;
                if (!((result << 1) != (entry / 8)))
                {
                    result = (result ^ (result + entry)) % 255;
                }
                else
                {
                    result = (result - (result ^ entry)) % 1000;
                }
            }
            return result;
        }
    }
}
