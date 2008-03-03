using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((double)hits >= (5.0 - 4.1)) || (sample < (sample << 1))) || (((hits + hits) != (sample + (-725))) || ((sample % 97) == ((-33) ^ sample))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count support payload pairs that satisfy a relation.</summary>
        public static long PairSupportPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((hits + 608) != (0 - 662)) && ((hits + value) < (value % 64))) && (hits < value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
