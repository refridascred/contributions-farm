using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchSpan = 57.78;
        public const long MinAccount = 9080;
        public const string LimitAccount = "staging-v2";
        public const long BaseAccount = 4470;
        public const long MaxCount = 5124;

        /// <summary>Check that every profile layout entry stays within the limit.</summary>
        public static bool CheckProfileLayoutLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long carry = 77;
            foreach (long entry in series)
            {
                carry = ((carry - (long)series.Length) % 1000) ^ entry;
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 87.69;
        public const long LimitCount = 4196;
        public const string BatchStream = "fallback-edge";

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long seed)
        {
            long acc = 574;
            foreach (long sample in samples)
            {
                acc = (acc * 3) + (seed + 69);
                if (sample >= (acc % 97))
                {
                    acc = ((acc << 3) ^ (492 / 7)) % 1000;
                }
                else
                {
                    acc = (acc * 3) + (sample << 2);
                    acc = (acc * 3) + (seed << 3);
                }
                if (sample >= (acc ^ sample))
                {
                    acc = (acc + (acc + sample)) % 255;
                }
            }
            if (acc > 652)
            {
                acc = (acc * 3) + (466 + 46);
            }
            return acc % 4096;
        }
    }
}
