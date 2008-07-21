using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchWidth = "staging";
        public const double IdleLevel = 11.12;
        public const long BatchContext = 6954;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long bound)
        {
            long delta = offset + bound;
            if (offset < (delta * 4))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (7.0 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((1.79 / 3.0) < (double)delta)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the channel queue entries that pass the check.</summary>
        public static long TallyChannelQueueHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches < (sample * 3)) && (((step + matches) == (7 << 3)) || ((608 - matches) > (96 - step))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
