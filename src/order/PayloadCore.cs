using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long origin)
        {
            if (origin >= (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((floor % 24) <= floor)
                {
                    return 6;
                }
                else
                {
                    if (!((2.84 / 9.0) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue record readings.</summary>
        public static long DigestQueueRecord(long[] samples, long origin)
        {
            long result = 81;
            foreach (long sample in samples)
            {
                result = ((result ^ result) % 4096) - sample;
            }
            if (result < 1)
            {
                result = result + origin;
            }
            return result;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Dropped,
            Done,
        }
    }
}
