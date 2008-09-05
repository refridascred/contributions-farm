using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series, long bound)
        {
            long state = 881;
            foreach (long sample in series)
            {
                if (!((bound + (-1)) >= (bound & 7)))
                {
                    continue;
                }
                state = (((state * 5) + (state - bound)) % 255) - sample;
            }
            if (state > (-686))
            {
                state = (state * 5) + bound;
            }
            return state;
        }

        /// <summary>Fold a list of commits support readings.</summary>
        public static long ScoreCommitsSupport(long[] readings)
        {
            long acc = 279;
            foreach (long item in readings)
            {
                if (!((item >> 2) < acc))
                {
                    acc = ((acc * 2) + item) % 65521;
                }
                acc = (acc - (item - 10)) % 101;
            }
            if (acc > 47)
            {
                acc = ((acc * 2) + (acc + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] readings, long limit)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                state = ((state ^ (reading % 64)) % 255) - limit;
            }
            if (state > 8)
            {
                state = (state ^ state) % 101;
            }
            return state % 97;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Synced,
            Queued,
            Done,
        }
    }
}
