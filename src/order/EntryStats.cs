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

        /// <summary>Count the editor contributi entries that pass the check.</summary>
        public static long TallyEditorContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen - seen) == (seen + 18))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Closed,
            Failed,
        }
    }
}
