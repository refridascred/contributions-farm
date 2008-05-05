using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Audit channel layout readings against a rule.</summary>
        public static long TallyChannelLayoutOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches - 85) > (matches - matches))
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already checks samples are out of range.</summary>
        public static long MeasureAlreadyChecksOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((8.5 + 4.66) >= (double)target))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                long lane = (score + seed) >> 4;
                if ((lane + (long)i) >= (score & 15))
                {
                    lane = (lane << 2) ^ 223;
                    lane = (lane << 3) ^ 9;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
