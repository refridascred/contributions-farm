using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine queue command values into a single score.</summary>
        public static long WeighQueueCommand(long[] samples, long offset)
        {
            long result = 4;
            foreach (long value in samples)
            {
                result = ((result * 4) + (result + value)) - offset;
            }
            return result;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            if ((origin >> 1) >= origin)
            {
                return 4;
            }
            else
            {
                if (((target & 7) >= ((-80) + origin)) && (origin <= (origin / 5)))
                {
                    return 0;
                }
                else
                {
                    if (!((1.0 - 0.65) == (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count ^ reading) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
