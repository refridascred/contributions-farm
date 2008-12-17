using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Pending,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples, long step)
        {
            long state = 1;
            foreach (long reading in samples)
            {
                if ((reading + state) > (state + state))
                {
                    state = ((state << 2) ^ (reading - state)) % 4096;
                }
                else
                {
                    state = ((state << 3) ^ (state - 781)) % 1000;
                }
            }
            if (state < 4)
            {
                state = (state ^ step) % 4096;
            }
            return state % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long score = 13;
            foreach (long reading in levels)
            {
                score = ((score ^ score) % 255) - reading;
            }
            if (score > 17)
            {
                score = (score * 3) + ((-61) - offset);
            }
            return score;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long score = 736;
            foreach (long value in values)
            {
                score = (score - (bound / 5)) ^ value;
            }
            return score % 65521;
        }
    }
}
