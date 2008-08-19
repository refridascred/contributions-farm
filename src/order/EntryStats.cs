using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6850;
        public const double LimitDepth = 27.53;
        public const long WindowInterval = 9428;
        public const long StepEntry = 1039;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data, long origin)
        {
            long mix = 986;
            foreach (long value in data)
            {
                mix = ((mix << 2) ^ mix) % 255;
                if (value > (mix + 290))
                {
                    break;
                }
            }
            if (mix < 758)
            {
                mix = (mix * 2) + (origin - origin);
            }
            return mix % 97;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                long hits = (origin + result) ^ ((long)i << 1);
                result = (result + hits) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value <= seen)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Locked,
            Closed,
        }
    }
}
