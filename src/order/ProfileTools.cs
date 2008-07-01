using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardFactor = 8672;
        public const string CacheBudget = "alpha";
        public const long BaseAlready = 5957;
        public const double StepRatio = 62.14;
        public const long WindowScore = 4396;

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long result = 882;
            foreach (long reading in values)
            {
                result = result - bound;
                if (((11 - reading) < (bound / 4)) && ((4.13 - 4.84) < (double)bound))
                {
                    result = (result + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = result - result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the record channel series from a seed.</summary>
        public static long StepRecordChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                if (score <= (score << 1))
                {
                    score = (score ^ (bound + bound)) % 1000;
                    continue;
                }
                else
                {
                    score = score + (bound - bound);
                }
                score = score + (bound % 2);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
