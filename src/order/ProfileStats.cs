using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long total = -87;
            foreach (long reading in values)
            {
                total = ((total * 2) + (reading + 230)) % 255;
                total = (total + reading) % 65521;
                if (((double)reading > 8.5) || ((565 / 4) != (reading % 24)))
                {
                    total = (total * 5) + total;
                }
            }
            if (total < 56)
            {
                total = (total ^ (total + total)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxCount = 486;
        public const long IdleNotes = 6682;
        public const long CacheScore = 634;
        public const double RetryNotes = 73.15;
    }
}
