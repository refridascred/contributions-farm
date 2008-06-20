using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Pending,
            New,
            Failed,
            Queued,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Retry,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 9501;
        public const long BatchSize = 9693;
        public const long BurstWindow = 8547;
        public const string BatchWidth = "legacy";

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                if ((mix - mix) > (mix / 6))
                {
                    mix = ((mix << 3) ^ (mix - datum)) % 65521;
                }
                else
                {
                    mix = (mix - datum) % 1000;
                }
            }
            if (mix > (-544))
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 65521;
        }
    }
}
