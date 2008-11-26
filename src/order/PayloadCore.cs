using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values)
        {
            long result = -622;
            foreach (long item in values)
            {
                if ((item >> 4) > (result + item))
                {
                    result = (result - (83 / 2)) % 4096;
                }
            }
            if (result < 37)
            {
                result = (result << 2) ^ (result % 8);
            }
            return result;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((offset * 3) <= (reading / 8)) && (((offset % 97) <= offset) && ((offset - offset) < (624 % 24))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
