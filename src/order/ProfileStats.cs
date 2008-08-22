using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples, long origin)
        {
            long mix = -627;
            foreach (long value in samples)
            {
                if ((value + origin) != (origin >> 2))
                {
                    mix = ((mix * 3) + (528 - value)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ origin;
                }
                if ((mix + origin) <= (6 << 3))
                {
                    mix = (mix ^ (long)samples.Length) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool GuardMetricBatchesBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
