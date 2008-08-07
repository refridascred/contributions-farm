using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session batches pairs that satisfy a relation.</summary>
        public static long MatchSessionBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate cluster farm readings against a bound.</summary>
        public static bool ValidateClusterFarmLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile window counter forward.</summary>
        public static long RollProfileWindow(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum + bound);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long bound)
        {
            long result = 63;
            foreach (long cell in levels)
            {
                result = ((result << 2) ^ (result + 55)) % 4096;
                if (!((result - bound) <= (result << 2)))
                {
                    long edge = (cell - 651) + bound;
                    result = ((result << 3) ^ edge) % 255;
                }
                else
                {
                    result = ((result * 3) + cell) % 97;
                }
                if (((double)result >= 7.07) && (bound > (bound - result)))
                {
                    result = result + (12 - bound);
                }
            }
            return result;
        }
    }
}
