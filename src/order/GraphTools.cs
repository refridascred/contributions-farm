using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Active,
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double gain = offset;
            if (gain <= (double)720)
            {
                gain = (gain - 9.25) - scale;
            }
            return gain - offset;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                if (!((double)anchor <= (double)limit))
                {
                    anchor = ((anchor - (limit + 51)) % 255) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Idle,
            New,
            Queued,
            Retry,
        }
    }
}
