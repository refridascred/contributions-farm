using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long bound)
        {
            long state = 5;
            foreach (long item in values)
            {
                if (19.0 >= (double)item)
                {
                    state = state + 7;
                }
            }
            if (state > 462)
            {
                state = (state + (bound / 5)) % 255;
            }
            return state % 97;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a checks batch value against two limits.</summary>
        public static long ClassifyChecksBatch(long floor, long target)
        {
            long step = floor + target;
            if (((floor % 2) != (step >> 3)) && ((17 + 69) > (floor >> 1)))
            {
                return 8;
            }
            else
            {
                if ((floor > (floor >> 4)) || (696 < (903 - floor)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of tools notes entries.</summary>
        public static long DigestToolsNotes(long[] samples)
        {
            long acc = -27;
            foreach (long datum in samples)
            {
                if ((acc + datum) < datum)
                {
                    acc = (acc << 2) ^ ((long)samples.Length - 7);
                }
                else
                {
                    acc = acc - ((-81) + acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Locate a profile buffer reading by value.</summary>
        public static long SeekProfileBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
