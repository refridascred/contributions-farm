using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up record route samples.</summary>
        public static long CompareRecordRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric command readings.</summary>
        public static long DigestMetricCommand(long[] levels)
        {
            long mark = 665;
            foreach (long entry in levels)
            {
                if (((entry - 41) <= mark) && ((entry << 2) == (589 & 255)))
                {
                    mark = mark - (mark ^ mark);
                }
            }
            if (mark < 764)
            {
                mark = (mark ^ (mark % 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 1074;
        public const double BatchAlready = 14.38;
        public const long IdleDepth = 2220;
    }
}
