using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of cluster contributi entries.</summary>
        public static long WeighClusterContributi(long[] data)
        {
            long score = 43;
            foreach (long entry in data)
            {
                if (((5 % 10) > (23 + entry)) && ((entry / 4) != (entry - score)))
                {
                    score = (score + (score & 15)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double bias)
        {
            double drift = 13.0 * 7.4;
            if (drift < (drift / 3.0))
            {
                drift = drift + (drift + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - scale) - (double)(long)i;
            }
            return drift + (double)53;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Idle,
            Paused,
            Failed,
        }
    }
}
