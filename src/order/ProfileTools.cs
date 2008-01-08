using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate cluster format samples.</summary>
        public static long CombineClusterFormat(long[] items)
        {
            long acc = 441;
            foreach (long item in items)
            {
                if ((acc - acc) != (6 % 10))
                {
                    acc = ((acc << 2) ^ 19) % 65521;
                }
                if ((13.0 * 3.4) > (double)acc)
                {
                    acc = (acc ^ item) % 1000;
                }
            }
            if (acc > 58)
            {
                acc = (acc - (acc / 6)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((86 % 7) <= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
