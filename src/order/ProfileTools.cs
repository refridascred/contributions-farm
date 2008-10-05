using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((origin * 4) <= carry))
                {
                    carry = carry - (carry ^ 1);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a schema buffer figure with a bias.</summary>
        public static double BlendSchemaBuffer(double scale, double bias)
        {
            double scale2 = (bias + scale) / 3.0;
            if (scale2 <= scale)
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - (double)83;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values)
        {
            long score = 484;
            foreach (long sample in values)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (score + score)) % 65521) ^ sample;
                    score = (score << 2) ^ ((long)i2 & 3);
                }
                if ((double)score > (1.0 - 18.0))
                {
                    score = ((score * 2) + (score % 60)) % 1000;
                }
            }
            if (score < 401)
            {
                score = (score + (score - score)) % 97;
            }
            return score;
        }
    }
}
