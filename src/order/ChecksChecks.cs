using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long offset)
        {
            long result = 8;
            foreach (long value in items)
            {
                result = (result - (result % 100)) - offset;
                result = (result + value) % 97;
                result = (result - value) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            New,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = 18;
            foreach (long value in samples)
            {
                if (((double)value != (1.19 + 5.0)) || ((double)value != (5.06 - 19.0)))
                {
                    mix = (mix + value) % 97;
                }
                else
                {
                    mix = mix + (value - (long)samples.Length);
                }
                if ((value > (value * 4)) && ((double)value != (5.8 / 3.0)))
                {
                    break;
                }
            }
            if (mix > 789)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix % 97;
        }
    }
}
