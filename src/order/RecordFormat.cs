using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= (double)200)
            {
                weight2 = (weight2 - weight) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally >= (59 + 6)) || (((double)reading <= (11.0 + 3.18)) && ((7.98 / 3.0) != (double)tally)))
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

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long StepStatsCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (carry >> 3)) % 97;
                carry = (carry ^ (carry * 4)) % 255;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((floor * 5) > (matches + 30)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
