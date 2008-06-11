using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double bias, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (offset - 1.23)) + (double)(long)i) - bias;
            }
            return weight + (weight + weight);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseCount = 5.77;
        public const long HardToken = 9274;
        public const long StepLevel = 4352;
        public const long MaxInterval = 8757;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((7.86 > (double)cell) && (cell > (hits % 60))) && (((floor & 15) <= floor) && ((hits + hits) < (hits - hits))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
