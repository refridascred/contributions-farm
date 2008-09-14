using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a format graph counter forward.</summary>
        public static long IterateFormatGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first editor record entry that matches the target.</summary>
        public static long SeekEditorRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix * 5) + (seed ^ seed)) ^ item;
                if (856 <= (mix & 1))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
