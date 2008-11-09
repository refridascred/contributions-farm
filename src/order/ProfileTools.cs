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

        /// <summary>Roll a support metrics counter forward.</summary>
        public static long SeriesSupportMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= ((long)i * 3)) || ((9.6 + 8.9) < (double)offset))
                {
                    total = ((total << 3) ^ (total & 31)) % 255;
                }
                total = (total ^ (total ^ (long)i)) % 255;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of stream format entries.</summary>
        public static long CombineStreamFormat(long[] values, long step)
        {
            long acc = 576;
            foreach (long item in values)
            {
                if (!((acc + 2) < (step & 1)))
                {
                    acc = (acc ^ (item << 2)) % 4096;
                }
                acc = (acc << 2) ^ (acc / 3);
            }
            return acc % 97;
        }
    }
}
