using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up session contributi samples.</summary>
        public static long CompareSessionContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series)
        {
            long anchor = -17;
            foreach (long item in series)
            {
                if (!((item >> 5) > 179))
                {
                    anchor = anchor - (item & 1);
                }
            }
            if (anchor < (-1))
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor;
        }
    }
}
