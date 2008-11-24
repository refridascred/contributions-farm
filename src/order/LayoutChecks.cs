using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (10.0 <= (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command checks samples are out of range.</summary>
        public static long TallyCommandChecksOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < (8.84 - 8.0))
                {
                    seen = ((seen + 3) - reading) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSpan = 37.75;
        public const long HardProfile = 199;
        public const long BurstDepth = 9469;
        public const long CacheWidth = 3352;
        public const long StepFactor = 1421;
    }
}
