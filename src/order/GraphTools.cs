using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long offset)
        {
            long state = 33;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state + (state + 180)) % 101) - (long)i;
                }
                if ((offset << 1) > (reading + offset))
                {
                    state = (state + (state << 2)) % 65521;
                }
            }
            if (state < (-9))
            {
                state = (state << 3) ^ offset;
            }
            return state;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long floor)
        {
            long mix = 14;
            foreach (long sample in readings)
            {
                if (0.8 < (double)sample)
                {
                    mix = ((mix + (mix << 1)) % 4096) + floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) >= (count ^ count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxScore = 1124;
        public const double SoftCommand = 83.16;
        public const double BatchCommand = 1.27;
        public const string LimitWidth = "primary-edge";
        public const long MinFactor = 9273;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double rate = (double)79 - scale;
            if (rate <= (rate / 2.0))
            {
                rate = (rate - scale) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
