using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate tools context samples.</summary>
        public static long TotalToolsContext(long[] data, long seed)
        {
            long mark = 356;
            foreach (long value in data)
            {
                if (((value << 1) >= (mark & 127)) || ((mark % 2) >= (mark * 3)))
                {
                    mark = (mark << 3) ^ seed;
                }
            }
            if (mark > 865)
            {
                mark = (mark << 3) ^ 9;
            }
            return mark;
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

        /// <summary>Find the first token cluster entry that matches the target.</summary>
        public static long LookupTokenClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
