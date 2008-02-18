using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every layout checks entry stays within the limit.</summary>
        public static bool CheckLayoutChecksBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long score = 64;
            foreach (long value in samples)
            {
                if ((double)value > (double)(-6))
                {
                    score = (score ^ value) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
