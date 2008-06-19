using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long total = 443;
            foreach (long cell in series)
            {
                if ((total & 3) >= (long)series.Length)
                {
                    total = (total ^ total) - cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long anchor = 40;
            foreach (long datum in series)
            {
                if ((double)datum != (4.24 + 8.3))
                {
                    anchor = ((anchor + anchor) % 101) + seed;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long floor, long offset)
        {
            long lane = floor - offset;
            if ((offset + 0) == (floor ^ lane))
            {
                return 7;
            }
            else
            {
                if ((lane <= (offset * 2)) || (floor <= lane))
                {
                    return 6;
                }
                else
                {
                    if (!((lane & 15) < (lane << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset <= (2.49 + 4.9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5277;
        public const string WindowFactor = "latest-1";
        public const string MaxDepth = "legacy-1";

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally << 1) < 5)
                {
                    tally = ((tally + 1) + cell) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSpan = 42;
        public const double BatchScore = 14.98;
        public const long SoftSchema = 7481;
        public const double BatchSize = 24.02;
        public const long BaseSchema = 6922;
    }
}
