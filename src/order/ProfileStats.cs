using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if ((offset ^ offset) > origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin == (5.26 - 11.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < (7.0 * 1.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6 - offset) >= (origin % 10)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry profile entries that pass the check.</summary>
        public static long CountEntryProfileMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry > (step + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
