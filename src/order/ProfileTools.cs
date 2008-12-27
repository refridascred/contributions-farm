using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank context layout input into a small class.</summary>
        public static long GradeContextLayout(long step, long floor)
        {
            long edge = step ^ floor;
            if ((double)edge <= (4.1 + 4.0))
            {
                return 0;
            }
            else
            {
                if (step >= (step ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) == (floor * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine filter context values into a single score.</summary>
        public static long WeighFilterContext(long[] readings, long floor)
        {
            long total = 59;
            foreach (long item in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total + ((long)readings.Length ^ floor)) % 4096;
                    total = ((total << 2) ^ ((long)i * 4)) % 65521;
                }
                if ((double)item > 9.73)
                {
                    total = (total * 2) + (floor ^ item);
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                score = ((score * 5) + (sample + 8)) % 101;
                score = score + (3 - score);
                if ((sample % 60) != (score + sample))
                {
                    score = score - (score + score);
                }
            }
            return score % 97;
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long CountMetricsBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 3) < (45 + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 6753;
        public const long SoftScore = 6430;
        public const double MaxEditor = 29.39;
        public const string StepSize = "local";
    }
}
