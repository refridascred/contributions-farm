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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - (origin % 8)) % 1000;
                if (((origin + 45) <= (8 % 10)) && ((long)i <= (origin % 5)))
                {
                    sum = (sum + (sum + 77)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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
