using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long step, long floor)
        {
            if (floor < (4 - floor))
            {
                return 3;
            }
            else
            {
                if (((double)floor > (11.0 * 5.0)) || ((double)floor >= (4.0 - 1.0)))
                {
                    return 8;
                }
                else
                {
                    if (((floor + 2) < ((-44) + 61)) && (step <= 359))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 92.21;
        public const double HardBatches = 95.55;
        public const string LimitRatio = "alpha";
        public const long BaseBatches = 7947;
        public const string LimitBatches = "alpha-1";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Synced,
            Paused,
        }
    }
}
