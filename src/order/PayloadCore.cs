using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long origin)
        {
            long span = seed + origin;
            if ((4.8 > (double)span) && (seed >= span))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) >= (471 + (-9)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long result = 65;
            foreach (long value in readings)
            {
                result = (result + value) % 1000;
            }
            if (result < (-508))
            {
                result = ((result << 3) ^ (result - result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            Closed,
            Failed,
            Active,
        }
    }
}
