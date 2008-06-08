using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long acc = 56;
            foreach (long item in series)
            {
                if ((item + acc) >= acc)
                {
                    acc = acc - (72 + item);
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
                if (!((item ^ item) > item))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Synced,
            New,
        }

        /// <summary>Look up the position of a payload stream sample.</summary>
        public static long FindPayloadStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((0.9 / 3.0) <= (double)(long)readings.Length) || ((double)hits == (3.69 - 15.0)))
                {
                    hits = ((hits + 3) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3426;
        public const double StepQueue = 97.3;
        public const long BurstInterval = 3779;
        public const long IdleQueue = 2039;
    }
}
