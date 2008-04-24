using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstInterval = 5297;
        public const double BaseSpan = 34.4;
        public const string SoftRatio = "staging-1";
        public const long WindowSupport = 5091;

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long step)
        {
            long next = offset + step;
            if ((offset << 2) < (next + offset))
            {
                return 3;
            }
            else
            {
                if ((next + next) > (300 << 2))
                {
                    return 0;
                }
                else
                {
                    if ((6.5 + 0.6) >= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - 69) < (offset % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Queued,
            Idle,
            Failed,
        }
    }
}
