using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6695;
        public const long StepAlready = 5209;
        public const long DefaultTimeout = 1215;
        public const long BurstWidth = 3161;
        public const long HardAlready = 4776;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels, long target)
        {
            long mark = 616;
            foreach (long sample in levels)
            {
                if ((target + target) == (sample >> 2))
                {
                    mark = (mark + (target & 255)) % 65521;
                }
            }
            if (mark < 546)
            {
                mark = (mark + (target + target)) % 1000;
            }
            return mark % 65521;
        }
    }
}
