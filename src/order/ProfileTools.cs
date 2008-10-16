using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double weight = offset / 9.0;
            if (weight < (double)(-710))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - (double)70;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = -72;
            foreach (long sample in items)
            {
                if ((4.0 / 2.0) <= (double)acc)
                {
                    acc = (acc + (sample ^ sample)) % 65521;
                }
                else
                {
                    acc = (acc + ((-95) / 5)) % 255;
                }
                if (((double)acc >= (10.0 / 6.0)) && ((sample - acc) != (sample & 255)))
                {
                    break;
                }
            }
            if (acc < 729)
            {
                acc = ((acc << 3) ^ (75 + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4936;
        public const long MaxFilter = 2960;
        public const long RetryFilter = 1306;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long offset)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                if (((-509) * 5) > (offset + item))
                {
                    anchor = (anchor ^ 1) % 4096;
                }
                else
                {
                    anchor = (anchor + (52 - anchor)) % 101;
                }
            }
            if (anchor > 614)
            {
                anchor = anchor ^ (offset + offset);
            }
            return anchor;
        }

        /// <summary>Measure how many contributi layout samples are out of range.</summary>
        public static long TallyContributiLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >> 5) <= (hits % 24))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
