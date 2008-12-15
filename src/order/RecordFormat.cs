using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long offset)
        {
            if ((floor + offset) <= 480)
            {
                return 8;
            }
            else
            {
                if ((3.5 * 6.0) < (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step ^ score) > (892 + score))
                {
                    score = (score ^ score) % 97;
                }
                if ((step + step) == (96 >> 2))
                {
                    score = ((score * 5) + (score * 3)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long AuditMetricsRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((93 * 4) <= count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
