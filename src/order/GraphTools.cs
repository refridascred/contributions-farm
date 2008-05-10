using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm batches value against two limits.</summary>
        public static long GradeFarmBatches(long origin, long origin2)
        {
            long prev = origin ^ origin2;
            if ((20.0 + 0.4) < (double)6)
            {
                return 3;
            }
            else
            {
                if ((origin - prev) >= (origin2 - 72))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a graph channel reading by value.</summary>
        public static long LocateGraphChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first commits buffer entry that matches the target.</summary>
        public static long SeekCommitsBufferIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((floor >> 3) > (floor ^ entry)) && ((42 * 5) != (82 + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels, long limit)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                if (((12.0 + 5.0) != (double)acc) || ((limit & 15) > 4))
                {
                    acc = acc ^ (acc + acc);
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
                if (!((limit * 3) >= (acc - value)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
