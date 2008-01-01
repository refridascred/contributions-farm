using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                if ((acc > (acc - acc)) || (((long)samples.Length + acc) <= (step % 2)))
                {
                    acc = ((acc + (675 / 3)) % 101) + item;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long mix = 567;
            foreach (long cell in samples)
            {
                if ((mix / 5) <= (mix % 16))
                {
                    mix = mix + (5 + mix);
                }
                if ((cell << 3) <= (375 ^ 6))
                {
                    break;
                }
            }
            return mix;
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
