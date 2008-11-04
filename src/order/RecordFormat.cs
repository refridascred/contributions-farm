using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long MatchBufferSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context schema samples.</summary>
        public static long DigestContextSchema(long[] series, long floor)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark - (mark * 4)) ^ sample;
                if ((floor & 255) < (764 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double bias2 = (floor / 9.0) * 9.3;
            if (bias2 < floor)
            {
                bias2 = bias2 + (bias2 - bias2);
            }
            return bias2 - (bias + bias2);
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items)
        {
            long result = 30;
            foreach (long entry in items)
            {
                if ((result + result) == ((-283) + result))
                {
                    result = ((result * 2) + result) % 1000;
                }
                else
                {
                    result = result + result;
                }
                result = (result - (entry + result)) % 101;
            }
            return result % 97;
        }
    }
}
