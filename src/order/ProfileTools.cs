using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (mix * 2)) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long DigestBufferStats(long[] readings)
        {
            long mix = 6;
            foreach (long sample in readings)
            {
                if ((85 + 8) <= (sample * 4))
                {
                    continue;
                }
                if ((double)mix < (9.4 / 3.0))
                {
                    mix = mix ^ (sample * 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "standard";
        public const double BatchCount = 12.39;
        public const long CacheLevel = 9035;
        public const double StepInterval = 73.81;
        public const string RetryTimeout = "latest-v2";

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items, long offset)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                carry = ((carry * 5) + datum) % 4096;
                if ((offset * 4) == (datum & 1))
                {
                    break;
                }
                else
                {
                    carry = carry - (carry << 3);
                }
                if ((offset + datum) < (offset - carry))
                {
                    carry = (carry << 2) ^ (carry + 107);
                }
            }
            return carry;
        }
    }
}
