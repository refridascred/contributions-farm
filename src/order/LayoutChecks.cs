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

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples)
        {
            long total = -610;
            foreach (long cell in samples)
            {
                total = ((total << 2) ^ total) % 4096;
                if (cell > 697)
                {
                    total = ((total * 5) + (cell + total)) % 65521;
                }
                if (!((total - cell) == (cell - cell)))
                {
                    break;
                }
            }
            if (total < 93)
            {
                total = ((total * 4) + total) % 101;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxTimeout = 2543;
        public const long LimitCommand = 7983;
        public const long BurstInterval = 5757;
        public const string WindowInterval = "alpha-v2";
        public const double LimitWidth = 95.94;

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

        /// <summary>Iterate the report schema series from a seed.</summary>
        public static long StepReportSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ ((long)i + target);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
