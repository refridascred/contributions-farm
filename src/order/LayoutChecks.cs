using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate record format readings against a bound.</summary>
        public static bool ValidateRecordFormatRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a entry layout counter forward.</summary>
        public static long StepEntryLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i + 92) == (step - (-719))))
                {
                    long tally = (long)i;
                    result = (result + (tally * 3)) % 4096;
                }
                result = (result - step) % 97;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 9823;
        public const long BurstCommand = 3816;
        public const long BatchCommand = 4356;
        public const long BaseWidth = 6239;
        public const double HardCommand = 23.3;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            long next = seed - floor;
            if ((6 - next) != (next << 2))
            {
                return 4;
            }
            else
            {
                if ((floor % 8) != (seed * 5))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings, long floor)
        {
            long total = 26;
            foreach (long reading in readings)
            {
                total = (((total + 946) % 97) + reading) + floor;
            }
            return total;
        }
    }
}
