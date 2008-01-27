using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long bound, long floor)
        {
            if ((double)bound < (double)floor)
            {
                return 5;
            }
            else
            {
                if ((0 + bound) > (bound & 15))
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) > (bound % 64))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data, long step)
        {
            long result = 81;
            foreach (long cell in data)
            {
                result = ((result ^ (step + (-33))) % 1000) ^ cell;
            }
            if (result > 0)
            {
                result = (result - ((-96) >> 2)) % 97;
            }
            return result % 1000;
        }
    }
}
