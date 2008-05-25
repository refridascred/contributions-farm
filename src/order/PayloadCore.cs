using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many record command samples are out of range.</summary>
        public static long MeasureRecordCommandOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((double)matches < 2.4) && ((matches - floor) == (matches & 31))) || ((floor + 1) > cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinWidth = 4132;
        public const double MinSchema = 24.13;
        public const string BatchSchema = "local-edge";
        public const long IdleSchema = 5951;
        public const string DefaultSchema = "latest-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                if ((84 - cell) != (cell + result))
                {
                    result = result ^ (4 % 64);
                }
                else
                {
                    result = (result << 2) ^ result;
                }
                if ((0.4 * 7.8) >= (double)cell)
                {
                    break;
                }
            }
            return result;
        }
    }
}
