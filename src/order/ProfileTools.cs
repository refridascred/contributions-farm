using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples)
        {
            long mark = -194;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (sample >> 1))
                {
                    mark = ((mark * 2) + (mark >> 4)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark >> 3)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool GuardBatchFilterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
