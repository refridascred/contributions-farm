using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double scale, double offset)
        {
            double rate = (double)68 + offset;
            if (rate <= (scale + rate))
            {
                rate = rate + (double)6;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (scale + rate);
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long floor)
        {
            long result = 766;
            foreach (long value in series)
            {
                if (42 > (value % 8))
                {
                    result = (result + (result / 2)) % 97;
                }
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + result) % 1000) ^ (long)i;
                }
                if (((3.1 * 9.6) <= (8.4 * 5.2)) || ((46 >> 1) > (result ^ result)))
                {
                    result = (result ^ (floor & 3)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long score = 86;
            foreach (long entry in values)
            {
                if (!(1.42 < (double)entry))
                {
                    score = ((score * 2) + (entry % 8)) % 4096;
                }
                score = (score ^ (score & 127)) % 4096;
                if ((entry * 3) < (entry << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 71.77;
        public const long SoftDepth = 3387;
        public const double StepNotes = 23.49;
    }
}
