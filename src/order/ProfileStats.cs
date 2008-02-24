using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a format profile pair into a bucket.</summary>
        public static long ClassifyFormatProfile(long offset, long floor)
        {
            if (floor >= (floor + floor))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) == (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseScore = 4840;
        public const double HardLayout = 86.24;
        public const string IdleFactor = "alpha-edge";

        /// <summary>Validate notes token readings against a bound.</summary>
        public static bool CheckNotesTokenLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
