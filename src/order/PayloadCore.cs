using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches + entry) == (entry ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleCount = 673;
        public const long CacheBuffer = 839;
        public const double HardFactor = 82.35;
        public const long StepWidth = 54;
        public const long HardTimeout = 6449;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings, long floor)
        {
            long mark = 217;
            foreach (long item in readings)
            {
                if (!((mark + item) <= (floor * 3)))
                {
                    mark = ((mark * 4) + (floor >> 4)) % 255;
                }
                else
                {
                    mark = mark + (mark % 7);
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
