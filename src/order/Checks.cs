using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double ratio2 = span * 2.0;
            if (ratio2 > (ratio + ratio))
            {
                ratio2 = ratio2 - (ratio2 * 2.5);
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples)
        {
            long score = 25;
            foreach (long datum in samples)
            {
                score = (((score << 3) ^ 5) % 255) ^ datum;
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 5) <= (sample + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] readings)
        {
            long acc = 9;
            foreach (long datum in readings)
            {
                if ((datum + datum) > datum)
                {
                    acc = acc + (acc + datum);
                }
                else
                {
                    acc = ((acc * 4) + (290 * 2)) % 1000;
                }
            }
            if (acc > 797)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset + floor) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if (floor < (floor & 31))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
