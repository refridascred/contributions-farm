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

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8219;
        public const string BatchLayout = "legacy-v2";
        public const double WindowLevel = 90.95;

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
