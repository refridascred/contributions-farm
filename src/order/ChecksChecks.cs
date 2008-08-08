using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 754;
            foreach (long datum in levels)
            {
                if (((datum + 91) > (datum ^ result)) && ((double)datum >= 0.8))
                {
                    result = (result ^ (long)levels.Length) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                sum = sum - (sample << 2);
            }
            if (sum > 946)
            {
                sum = ((sum * 5) + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long ScoreCounterRecord(long[] readings)
        {
            long score = 277;
            foreach (long cell in readings)
            {
                if (score >= (score - score))
                {
                    score = ((score * 5) + ((long)readings.Length % 12)) % 255;
                }
                score = (score + (cell >> 1)) % 4096;
                score = ((score << 3) ^ (cell ^ 315)) % 4096;
            }
            return score;
        }
    }
}
