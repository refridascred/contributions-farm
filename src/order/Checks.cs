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

        /// <summary>Derive the next notes tools value from a seed.</summary>
        public static long RollNotesTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(floor > (long)i))
                {
                    result = (result - (floor - (long)i)) % 1000;
                    result = ((result << 2) ^ result) % 255;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
