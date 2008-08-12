using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "strict-v2";
        public const long HardScore = 9078;
        public const long DefaultFactor = 2744;

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double scale = (double)9 * 7.4;
            return (scale + bias) + bias2;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long step, long floor)
        {
            long span = step + floor;
            if ((double)step < 0.8)
            {
                return 7;
            }
            else
            {
                if (((floor / 4) >= (span + step)) || ((span + span) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((span + floor) == (step + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] items)
        {
            long acc = 6;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum >> 2);
                acc = acc ^ (acc % 100);
            }
            if (acc > 45)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Roll a schema tools counter forward.</summary>
        public static long DeriveSchemaTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result - ((long)i * 3)) % 4096;
                result = (result ^ result) % 65521;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
