using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "cached-edge";
        public const long IdleScore = 4056;
        public const long SoftFilter = 204;
        public const long LimitBudget = 8663;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long offset)
        {
            long mix = 103;
            foreach (long sample in series)
            {
                if ((offset + mix) >= (sample - 94))
                {
                    mix = (mix * 3) + (26 % 24);
                }
            }
            if (mix > 826)
            {
                mix = mix - offset;
            }
            return mix % 4096;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
