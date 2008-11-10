using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long seed)
        {
            long sum = 47;
            foreach (long datum in samples)
            {
                if ((sum + seed) != (seed >> 1))
                {
                    sum = (sum * 3) + (datum & 15);
                }
                else
                {
                    sum = ((sum << 2) ^ (seed * 4)) % 97;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (seed / 7)) % 255;
            }
            return sum;
        }

        /// <summary>Match up buffer report samples.</summary>
        public static long CompareBufferReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
