using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings)
        {
            long result = 64;
            foreach (long item in readings)
            {
                if (((item >> 5) > item) || (item > (65 / 7)))
                {
                    result = (result - (item << 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1757;
        public const double RetryRoute = 9.34;
        public const string HardRoute = "staging-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((long)data.Length % 60) != (item + seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double bias2 = bias + span;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - 1.0;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long origin)
        {
            long score = 94;
            foreach (long value in samples)
            {
                if (((38 / 5) < (origin + origin)) && ((2 - value) >= origin))
                {
                    score = score ^ ((long)samples.Length & 127);
                }
            }
            return score % 1000;
        }
    }
}
