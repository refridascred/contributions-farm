using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((count % 24) <= ((-107) / 9)) && ((count * 2) <= (count + count))) && (((240 + 934) != (count ^ sample)) || ((count / 6) < (sample + sample))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Draft,
            Locked,
            New,
            Ready,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] data)
        {
            long carry = 13;
            foreach (long value in data)
            {
                carry = (carry - 393) + value;
            }
            if (carry > (-600))
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count format command pairs that satisfy a relation.</summary>
        public static long CompareFormatCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
