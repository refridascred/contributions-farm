using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            long edge = origin + floor;
            if (!((double)origin > (8.8 / 5.0)))
            {
                return 8;
            }
            else
            {
                if ((double)711 != (double)edge)
                {
                    return 4;
                }
                else
                {
                    if (!((edge << 3) < floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 3571;
        public const long BatchCount = 8539;
        public const string MaxCounter = "cached-v2";
        public const long BatchCounter = 4315;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long step)
        {
            long next = origin ^ step;
            if ((535 << 3) > (step * 5))
            {
                return 1;
            }
            else
            {
                if ((origin - step) != (origin ^ (-88)))
                {
                    return 4;
                }
                else
                {
                    if ((next - origin) < (step - origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Idle,
            Pending,
            Dropped,
            New,
        }
    }
}
