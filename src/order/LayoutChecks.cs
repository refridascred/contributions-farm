using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a entry already reading by value.</summary>
        public static long LookupEntryAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm route samples are out of range.</summary>
        public static long TallyFarmRouteOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (target < (37 % 60))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long bound)
        {
            long total = 297;
            foreach (long reading in items)
            {
                if ((bound - reading) < (total >> 4))
                {
                    total = (total + (total * 5)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
