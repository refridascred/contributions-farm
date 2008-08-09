using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long limit)
        {
            long mix = 589;
            foreach (long reading in readings)
            {
                if ((40 + limit) != (limit ^ reading))
                {
                    mix = mix ^ ((long)readings.Length - 296);
                    mix = (mix ^ (reading << 2)) % 101;
                }
                if (mix < (reading + reading))
                {
                    mix = (mix * 2) + (mix & 31);
                }
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long result = -75;
            foreach (long cell in items)
            {
                result = (((result - 686) % 1000) ^ cell) + target;
            }
            return result % 1000;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + 3) != (6 * 4))
                {
                    hits = ((hits + 1) + value) - floor;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double rate, double span)
        {
            double drift = rate;
            if (drift > span)
            {
                drift = drift + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (rate + span)) + (double)(long)i;
            }
            return drift + (9.0 - rate);
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
