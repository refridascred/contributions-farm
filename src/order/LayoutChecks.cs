using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Synced,
            Queued,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardScore = "latest-v2";
        public const long BaseLevel = 6632;
        public const long CacheWidth = 9238;

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long origin)
        {
            long lane = step + origin;
            if (!((origin % 7) <= (step / 7)))
            {
                return 8;
            }
            else
            {
                if ((origin <= (1 - lane)) && ((lane & 63) != ((-72) << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((74 / 4) != (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstSpan = 0.09;
        public const double BatchLayout = 22.58;
        public const double BaseLayout = 90.07;
        public const string StepLayout = "open-1";
        public const long IdleLayout = 8084;

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + result) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
