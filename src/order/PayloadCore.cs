using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            if ((offset ^ bound) >= (bound + offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (double)28)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (bound & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
