using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardCount = 8151;
        public const long MaxStream = 8681;
        public const long CacheCount = 9059;
        public const long HardStream = 9216;
        public const long SoftStream = 7288;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long bound)
        {
            if ((bound & 3) >= seed)
            {
                return 6;
            }
            else
            {
                if (((bound + seed) != (seed % 5)) || ((bound / 3) > (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 3) != (8 >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound ^ 0) <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxInterval = 20.87;
        public const long WindowBatches = 2586;
        public const long StepSpan = 2760;
        public const string HardBatches = "stable-v2";
        public const double BatchBatches = 61.43;
    }
}
