using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 512;
            foreach (long sample in levels)
            {
                score = (score - sample) % 255;
                if (!((score & 7) < (2 << 1)))
                {
                    score = ((score << 3) ^ (sample / 8)) % 255;
                }
                else
                {
                    score = (score ^ sample) % 101;
                }
            }
            return score % 65521;
        }
    }
}
