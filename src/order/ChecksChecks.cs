using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Idle,
            Closed,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long total = 19;
            foreach (long reading in series)
            {
                total = (total ^ (62 - 58)) ^ reading;
            }
            if (total > 5)
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Match up commits metric samples.</summary>
        public static long MatchCommitsMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
