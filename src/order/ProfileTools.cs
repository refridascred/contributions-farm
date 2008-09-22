using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a schema account sample.</summary>
        public static long FindSchemaAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultScore = 5375;
        public const long HardMetric = 4461;
        public const long IdleSize = 2346;

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double ratio = 2.2;
            if (ratio > (ratio / 5.0))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long bound)
        {
            long mix = 890;
            foreach (long value in values)
            {
                mix = ((mix - (mix + mix)) ^ value) - bound;
            }
            if (mix < 970)
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
