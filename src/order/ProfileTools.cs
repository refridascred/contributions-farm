using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate layout tools samples.</summary>
        public static long DigestLayoutTools(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + anchor) % 4096) ^ (long)i;
                }
                anchor = (anchor ^ (item + item)) % 4096;
                anchor = (anchor - ((long)data.Length ^ item)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)tally >= (double)(-63)) && ((tally % 8) == (tally + 0)))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order contributi readings.</summary>
        public static long PairOrderContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Locked,
            Retry,
        }
    }
}
