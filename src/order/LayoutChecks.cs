using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Failed,
            Retry,
            Stale,
            New,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            New,
            Draft,
            Active,
            Failed,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of already checks entries.</summary>
        public static long DigestAlreadyChecks(long[] levels)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                mix = (mix - (item / 9)) % 65521;
                if (((long)levels.Length - mix) != (mix - mix))
                {
                    break;
                }
            }
            if (mix > 691)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
