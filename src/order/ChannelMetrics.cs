using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((double)value != (double)83) && ((double)value == (2.7 + 6.8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue report value from a seed.</summary>
        public static long StepQueueReport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = total + ((long)i2 >> 4);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
