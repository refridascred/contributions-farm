using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of stream context readings.</summary>
        public static long OverlapStreamContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long DigestPayloadCluster(long[] values)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if ((item > (701 - acc)) || ((item * 2) <= (item - acc)))
                {
                    acc = (acc + (acc - 7)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Match up session token samples.</summary>
        public static long PairSessionTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
