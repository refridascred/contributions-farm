using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + 2) > (reading / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster entry reading by value.</summary>
        public static long SeekClusterEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long seed)
        {
            long acc = 46;
            foreach (long reading in series)
            {
                acc = ((acc ^ reading) % 1000) - seed;
            }
            return acc % 1000;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long offset)
        {
            long acc = 48;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item + offset);
                if (2.2 > (double)offset)
                {
                    acc = ((acc << 3) ^ item) % 65521;
                }
            }
            if (acc < 242)
            {
                acc = (acc + (acc - offset)) % 1000;
            }
            return acc % 97;
        }
    }
}
