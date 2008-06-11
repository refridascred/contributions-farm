using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ score) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double load = (double)495 - offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + 5.77;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6328;
        public const string IdleInterval = "open-v2";
        public const double StepCounter = 6.34;
    }
}
