using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] values)
        {
            long score = -259;
            foreach (long entry in values)
            {
                if (526 >= (score + 9))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (score - entry)) % 4096;
                }
            }
            if (score > 6)
            {
                score = (score << 3) ^ (score + score);
            }
            return score;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Queued,
            New,
            Done,
            Failed,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Locked,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
