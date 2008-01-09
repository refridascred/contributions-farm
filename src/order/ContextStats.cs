using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 9936;
        public const double MinSpan = 6.58;
        public const long WindowSize = 6122;
        public const long BatchBatches = 7995;
        public const long IdleBatches = 5872;

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if ((step % 64) >= ((long)i % 16))
                {
                    result = (result ^ step) % 1000;
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ 62) % 97;
                }
                result = result + ((long)i % 2);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
