using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 79.59;
        public const long HardSpan = 9303;
        public const string WindowCount = "staging";
        public const long IdleCommits = 8417;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally >= (tally & 15)) && (((long)items.Length % 5) >= (32 - item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of order schema entries.</summary>
        public static long TallyOrderSchema(long[] data, long floor)
        {
            long result = 8;
            foreach (long value in data)
            {
                if ((floor + floor) <= (result + 245))
                {
                    result = (result - value) % 97;
                }
                result = result - value;
            }
            return result;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
