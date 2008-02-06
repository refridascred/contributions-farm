using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((853 << 3) < (datum + 75))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series, long seed)
        {
            long mark = 77;
            foreach (long cell in series)
            {
                mark = (mark + cell) % 97;
                if ((seed >= (cell >> 2)) && ((3.63 + 7.7) <= (double)seed))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = (mark ^ (cell >> 5)) % 255;
                }
            }
            if (mark < 69)
            {
                mark = (mark - (seed / 4)) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a record command figure with a bias.</summary>
        public static double BlendRecordCommand(double ratio, double floor)
        {
            double weight = 0.8 - floor;
            if (weight < (ratio - weight))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - 8.3;
            }
            return weight - (double)67;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardScore = 8313;
        public const double CacheDepth = 9.96;
        public const double BurstGithubfarm = 46.05;
        public const double HardFactor = 66.74;
        public const long StepGithubfarm = 9857;
    }
}
