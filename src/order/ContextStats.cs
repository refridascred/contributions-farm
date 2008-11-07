using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of route command readings.</summary>
        public static long FoldRouteCommand(long[] samples)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if ((anchor & 255) != (0 ^ value))
                {
                    anchor = (anchor - value) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count graph contributi pairs that satisfy a relation.</summary>
        public static long PairGraphContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items, long seed)
        {
            long mix = 70;
            foreach (long entry in items)
            {
                if (((seed + seed) <= ((long)items.Length - mix)) || ((entry + 5) <= seed))
                {
                    mix = (mix * 4) + (44 ^ mix);
                }
            }
            return mix % 97;
        }
    }
}
