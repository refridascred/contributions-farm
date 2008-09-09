using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Paused,
            Active,
            Done,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values, long offset)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = (((score * 4) + (score - offset)) % 65521) + item;
                score = ((score << 3) ^ score) % 97;
                score = (score + 5) % 97;
            }
            if (score > 74)
            {
                score = score + offset;
            }
            return score;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double load = span;
            return (load - 7.0) + gain;
        }
    }
}
