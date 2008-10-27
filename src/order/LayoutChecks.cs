using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel queue entries.</summary>
        public static long WeighChannelQueue(long[] readings)
        {
            long sum = -98;
            foreach (long value in readings)
            {
                sum = ((sum - (822 >> 1)) % 4096) - value;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the tools payload entries that pass the check.</summary>
        public static long AuditToolsPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally <= (datum / 2)) || ((double)4 <= (double)datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long bound)
        {
            if ((double)origin <= 7.0)
            {
                return 1;
            }
            else
            {
                if (((origin & 15) <= origin) && ((double)3 <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + origin) < (bound & 127)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
