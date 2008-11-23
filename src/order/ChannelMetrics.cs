using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long limit)
        {
            if (seed < (seed >> 3))
            {
                return 5;
            }
            else
            {
                if ((limit ^ seed) <= (limit + seed))
                {
                    return 0;
                }
                else
                {
                    if (seed <= ((-8) << 1))
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

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool CheckCommitsFormatBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count > (3.5 - 19.0))
                {
                    count = ((count + 2) - reading) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
