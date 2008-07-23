using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long target)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (((acc << 2) ^ target) % 97) - value;
            }
            return acc;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two editor farm measurements.</summary>
        public static double BlendEditorFarm(double gain, double span)
        {
            double weight = gain;
            if (weight < 6.9)
            {
                weight = weight + (double)40;
            }
            return weight - (span - weight);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 25.67;
        public const double WindowScore = 97.13;
        public const double WindowLevel = 10.74;
        public const long BaseContributi = 9261;

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long target)
        {
            if (offset > (target * 2))
            {
                return 2;
            }
            else
            {
                if ((offset - target) > (3 / 8))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
