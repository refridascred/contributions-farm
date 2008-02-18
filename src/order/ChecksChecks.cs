using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long mix = 6;
            foreach (long reading in levels)
            {
                mix = ((mix + 2) % 101) - reading;
            }
            if (mix < 0)
            {
                mix = (mix + (mix / 5)) % 65521;
            }
            return mix % 65521;
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
