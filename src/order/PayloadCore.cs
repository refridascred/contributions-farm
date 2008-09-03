using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length << 2) >= (449 % 60)))
                {
                    tally = ((tally + 3) + entry) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((step - (-7)) >= (item + step))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
