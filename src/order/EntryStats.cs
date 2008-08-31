using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count >= (step * 5))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySize = 9214;
        public const string MaxReport = "staging-v2";
        public const long MinTimeout = 6778;

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings)
        {
            long total = 655;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + ((-4) + total)) + (long)i;
                }
                total = ((total * 3) + reading) % 65521;
            }
            if (total > (-6))
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ ((long)i ^ (long)i);
                if (!(result < (step + (long)i)))
                {
                    result = (result * 4) + (step * 4);
                }
                if (!((step & 15) < step))
                {
                    result = (result - (step * 5)) % 101;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
