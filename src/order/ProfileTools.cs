using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Paused,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long WeighRecordBatches(long[] series, long bound)
        {
            long result = 32;
            foreach (long reading in series)
            {
                if ((result << 1) <= (64 >> 1))
                {
                    result = (result << 2) ^ (reading ^ 0);
                }
                if ((result / 8) != (bound + bound))
                {
                    break;
                }
            }
            return result;
        }
    }
}
