using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches % 2) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the channel payload entries that pass the check.</summary>
        public static long TallyChannelPayloadMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item % 100) < (step + step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
