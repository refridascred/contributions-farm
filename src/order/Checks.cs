using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long mix = -5;
            foreach (long value in values)
            {
                mix = (mix << 2) ^ value;
                if ((mix + mix) <= (value + value))
                {
                    mix = ((mix << 2) ^ (957 >> 2)) % 255;
                    break;
                }
                if ((double)value > (3.1 * 17.0))
                {
                    mix = (mix ^ (mix >> 5)) % 1000;
                }
            }
            if (mix < 6)
            {
                mix = mix + (1 & 255);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many metrics checks samples are out of range.</summary>
        public static long CountMetricsChecksOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (1.7 - 7.4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum < (9 >> 2)) && ((((long)data.Length - bound) == (tally - tally)) && ((double)tally <= (0.4 - 16.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
