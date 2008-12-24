using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long carry = 2;
            foreach (long sample in values)
            {
                carry = (carry + (-46)) + sample;
            }
            return carry % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long bound)
        {
            if ((seed + seed) <= seed)
            {
                return 3;
            }
            else
            {
                if (seed <= bound)
                {
                    return 4;
                }
                else
                {
                    if (!((bound << 2) < 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = -24;
            foreach (long item in samples)
            {
                mix = ((mix + (mix * 4)) % 101) - item;
            }
            return mix;
        }
    }
}
