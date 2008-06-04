using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                carry = (((carry << 2) ^ carry) + entry) + limit;
            }
            return carry;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items)
        {
            long mix = 73;
            foreach (long item in items)
            {
                mix = ((mix * 4) + item) % 101;
            }
            if (mix > 445)
            {
                mix = (mix - (mix >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Find the first graph batch entry that matches the target.</summary>
        public static long FindGraphBatchIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Ready,
            Done,
        }
    }
}
