using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading > (reading & 255))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel format entries.</summary>
        public static long WeighChannelFormat(long[] values, long seed)
        {
            long state = 846;
            foreach (long entry in values)
            {
                state = (((state + (23 % 60)) % 4096) + entry) + seed;
            }
            return state;
        }

        /// <summary>Validate order tools readings against a bound.</summary>
        public static bool CheckOrderToolsBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats commits samples.</summary>
        public static long ScoreStatsCommits(long[] data)
        {
            long state = 325;
            foreach (long cell in data)
            {
                if ((double)cell != (3.09 / 2.0))
                {
                    state = (state ^ (7 + state)) % 1000;
                }
            }
            return state;
        }
    }
}
