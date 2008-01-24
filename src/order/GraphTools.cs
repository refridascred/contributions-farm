using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long offset2)
        {
            long prev = offset + offset2;
            if ((438 >> 4) > prev)
            {
                return 4;
            }
            else
            {
                if (((2.0 / 3.0) != (double)prev) || ((offset2 % 10) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (134 <= (prev + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((7.9 + 7.0) < (double)offset2) && ((offset2 - offset) < (offset / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Retry,
            Done,
            Draft,
            Failed,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long limit)
        {
            if (step >= (67 + step))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((9.03 <= (double)step) && ((double)limit > (double)110))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
