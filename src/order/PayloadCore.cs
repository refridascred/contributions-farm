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

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long mix = -845;
            foreach (long sample in readings)
            {
                mix = ((mix + mix) % 4096) + sample;
            }
            if (mix < 4)
            {
                mix = ((mix << 3) ^ (mix % 7)) % 101;
            }
            return mix;
        }
    }
}
