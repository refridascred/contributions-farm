using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long carry = 72;
            foreach (long value in data)
            {
                if (((carry + value) >= ((-104) - carry)) || ((value << 1) != (7 + 4)))
                {
                    carry = (carry - (value + value)) % 65521;
                }
            }
            if (carry > 62)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] values)
        {
            long score = 4;
            foreach (long cell in values)
            {
                if (score < (score * 4))
                {
                    score = ((score - score) % 1000) ^ cell;
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double gain, double span)
        {
            double mean = span;
            return (mean - (mean / 8.0)) + gain;
        }
    }
}
