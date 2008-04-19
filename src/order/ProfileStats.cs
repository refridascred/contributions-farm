using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double load = floor;
            if (load > (1.1 * 8.7))
            {
                load = load - (load - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                if (((mark + entry) != (mark + 1)) || ((entry * 5) > (mark ^ entry)))
                {
                    mark = (mark + mark) % 255;
                }
            }
            if (mark < (-769))
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
