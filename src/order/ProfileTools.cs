using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] samples, long floor)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value + result)) % 97;
                if ((value >> 5) < floor)
                {
                    result = result + (floor & 63);
                }
            }
            return result % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 851;
        public const long HardSize = 2030;
        public const long MaxLevel = 7941;
        public const long DefaultCache = 6987;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((11.0 / 4.0) < (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
