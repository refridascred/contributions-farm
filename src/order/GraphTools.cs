using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many context support samples are out of range.</summary>
        public static long AuditContextSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((169 + count) >= (cell + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Retry,
            New,
            Idle,
            Queued,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Ready,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Roll a record command counter forward.</summary>
        public static long SeriesRecordCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
