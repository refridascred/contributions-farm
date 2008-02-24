using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long offset2)
        {
            if ((double)offset < 1.0)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (3.0 + 8.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long TallyAccountContributiMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((double)23 < (double)tally) && ((bound + tally) >= (value / 2))) && !(tally < (tally + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
