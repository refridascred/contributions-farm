using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long WeighNotesFarm(long[] samples)
        {
            long acc = 7;
            foreach (long value in samples)
            {
                if ((5.0 + 8.8) >= (double)acc)
                {
                    acc = (acc + (value << 1)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + value) % 101;
                }
                if ((value - acc) < (acc ^ value))
                {
                    break;
                }
            }
            if (acc > 898)
            {
                acc = (acc * 3) + (acc % 12);
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a context checks sample.</summary>
        public static long SeekContextChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
