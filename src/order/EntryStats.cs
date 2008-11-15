using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long floor)
        {
            if (((233 + 379) > (floor + offset)) && (floor >= offset))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) < (offset + floor))
                {
                    return 4;
                }
                else
                {
                    if ((60 - floor) >= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor * 2) > (floor + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Idle,
            Synced,
            New,
        }

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long PairGraphSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report route readings against a rule.</summary>
        public static long MeasureReportRouteMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (4.0 >= (double)entry)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
