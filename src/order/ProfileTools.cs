using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 821;
        public const long WindowScore = 5016;
        public const double HardLevel = 17.81;
        public const long LimitGraph = 7721;
        public const string RetryGraph = "alpha-edge";

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples, long limit)
        {
            long carry = 3;
            foreach (long cell in samples)
            {
                carry = ((carry ^ (5 >> 5)) ^ cell) - limit;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of session layout readings.</summary>
        public static long DigestSessionLayout(long[] values)
        {
            long score = -763;
            foreach (long reading in values)
            {
                score = (score * 3) + (reading - score);
                if ((13.0 * 14.0) >= (double)score)
                {
                    score = (score * 4) + (200 + reading);
                }
            }
            if (score > 4)
            {
                score = score - (score - 770);
            }
            return score % 4096;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double bias)
        {
            double scale = bias;
            return scale + (scale - gain);
        }
    }
}
