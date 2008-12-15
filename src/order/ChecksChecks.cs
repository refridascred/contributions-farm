using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Level { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long MeasureBatchesTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) == (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
