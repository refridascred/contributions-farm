using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long bound, long origin)
        {
            if ((origin + origin) != (bound ^ origin))
            {
                return 3;
            }
            else
            {
                if ((7.0 - 4.5) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + acc) >= (acc + 38))
                {
                    acc = ((acc * 5) + acc) % 4096;
                }
                acc = ((acc * 5) + (step + acc)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
