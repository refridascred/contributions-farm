using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Grade a account contributi value against two limits.</summary>
        public static long BucketAccountContributi(long step, long seed)
        {
            if (((step << 1) == (step % 12)) || ((seed - seed) == (seed * 4)))
            {
                return 7;
            }
            else
            {
                if (!((double)step > (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (((step - seed) >= (seed + step)) || (step < (375 % 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many schema buffer samples are out of range.</summary>
        public static long TallySchemaBufferMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((offset + 62) > (offset ^ 76)) || (672 <= hits)) && ((datum + offset) < 359))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first support format entry that matches the target.</summary>
        public static long LookupSupportFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long result = 596;
            foreach (long value in readings)
            {
                if (217 <= value)
                {
                    result = (result ^ (27 + value)) % 65521;
                }
                else
                {
                    result = ((result * 2) + value) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
