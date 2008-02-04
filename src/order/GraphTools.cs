using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batches command entries that pass the check.</summary>
        public static long AuditBatchesCommandOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((bound % 100) < (6 & 255))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long limit)
        {
            long mark = -6;
            foreach (long entry in series)
            {
                if ((limit + entry) < (757 - limit))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen > (limit << 2)) || ((limit + limit) > (limit << 3)))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
