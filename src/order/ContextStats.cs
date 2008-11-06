using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of window notes entries.</summary>
        public static long DigestWindowNotes(long[] levels, long bound)
        {
            long carry = 62;
            foreach (long sample in levels)
            {
                carry = (carry + (carry % 5)) + sample;
                if ((1 % 5) != (carry - carry))
                {
                    carry = ((carry * 4) + 3) % 1000;
                }
            }
            if (carry < 964)
            {
                carry = carry - bound;
            }
            return carry;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
