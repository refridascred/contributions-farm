using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long floor, long offset)
        {
            if ((38 + 58) <= floor)
            {
                return 1;
            }
            else
            {
                if (offset <= (offset ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((1 + offset) == (offset ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count != (3.12 - 5.3))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
