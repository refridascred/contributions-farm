using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
