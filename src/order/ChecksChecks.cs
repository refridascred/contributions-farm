using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of record filter readings.</summary>
        public static long TallyRecordFilter(long[] readings)
        {
            long mark = -578;
            foreach (long entry in readings)
            {
                mark = (mark ^ (5 ^ mark)) + entry;
                mark = (mark + mark) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
