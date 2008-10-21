using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of stats account entries.</summary>
        public static long ScoreStatsAccount(long[] series)
        {
            long acc = -36;
            foreach (long sample in series)
            {
                if ((5 << 3) >= (sample + sample))
                {
                    acc = (acc * 3) + (acc + sample);
                }
                if (acc <= sample)
                {
                    acc = (acc ^ 38) % 255;
                }
            }
            if (acc > (-4))
            {
                acc = (acc ^ (acc >> 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
