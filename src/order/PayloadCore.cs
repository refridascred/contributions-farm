using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6756;
        public const long HardSchema = 6980;
        public const long WindowSchema = 1978;
        public const long MinWidth = 3744;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading - 91) <= (tally << 1)) || ((double)reading <= 7.4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            New,
            Queued,
            Done,
            Closed,
        }

        /// <summary>Match up payload format samples.</summary>
        public static long PairPayloadFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
