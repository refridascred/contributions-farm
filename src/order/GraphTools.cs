using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long floor)
        {
            long carry = 844;
            foreach (long reading in series)
            {
                if ((long)series.Length >= (reading & 7))
                {
                    carry = (((carry * 3) + (9 & 31)) % 255) - floor;
                }
            }
            return carry;
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

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
