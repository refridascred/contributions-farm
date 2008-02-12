using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] readings, long offset)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                total = (((total << 2) ^ (total - offset)) % 4096) - datum;
            }
            return total % 1000;
        }

        /// <summary>Rank metrics support input into a small class.</summary>
        public static long ClassifyMetricsSupport(long floor, long bound)
        {
            if ((double)floor <= (4.05 - 5.4))
            {
                return 4;
            }
            else
            {
                if (((bound + floor) > (bound / 8)) || (floor < (bound % 10)))
                {
                    return 5;
                }
                else
                {
                    if (0.59 > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] samples, long bound)
        {
            long result = 98;
            foreach (long datum in samples)
            {
                result = ((result * 4) + (result ^ 700)) ^ datum;
                result = result ^ bound;
            }
            return result % 65521;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + seed) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
