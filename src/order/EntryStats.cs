using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long seed)
        {
            long next = origin - seed;
            if ((2 <= (seed - seed)) || ((next - seed) <= 1))
            {
                return 3;
            }
            else
            {
                if (next > (seed + next))
                {
                    return 0;
                }
                else
                {
                    if (((5.26 * 7.8) != (double)origin) || ((9.91 / 5.0) < (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + seed) >= (seed - next)) && (origin < (next + next)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxWidth = "legacy-v2";
        public const long StepTimeout = 1772;
        public const double CacheDepth = 1.09;
        public const long BatchBuffer = 9157;

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
