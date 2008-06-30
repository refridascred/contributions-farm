using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings)
        {
            long score = 817;
            foreach (long item in readings)
            {
                if (!((score >> 5) < item))
                {
                    score = (score + (score >> 3)) % 255;
                }
                score = score ^ 2;
            }
            return score % 1000;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) <= (0 % 16))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "legacy-1";
        public const long RetryDepth = 6503;
        public const long StepStats = 8058;
        public const string BatchStats = "fallback";
        public const double SoftCount = 7.47;

        /// <summary>Blend two already profile measurements.</summary>
        public static double AdjustAlreadyProfile(double gain, double offset)
        {
            double weight = (double)(46 * 3);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + gain) - (double)(long)i) + offset;
            }
            return weight - weight;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Closed,
            Idle,
        }
    }
}
