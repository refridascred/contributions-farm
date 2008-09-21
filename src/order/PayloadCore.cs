using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double bias)
        {
            double weight = (bias / 4.0) - rate;
            return weight + rate;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                if ((180 >> 4) <= value)
                {
                    break;
                }
                else
                {
                    score = (score ^ (value % 24)) % 101;
                    score = score + (value - 95);
                }
                score = score + (score ^ value);
                if (score >= 439)
                {
                    score = (score ^ (score - score)) % 65521;
                }
            }
            if (score < 1)
            {
                score = (score + score) % 101;
            }
            return score % 97;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry contributi samples.</summary>
        public static long DigestEntryContributi(long[] data, long bound)
        {
            long anchor = 718;
            foreach (long cell in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor - ((-69) + anchor)) ^ (long)i;
                }
                if ((anchor + 926) > (cell & 7))
                {
                    anchor = (anchor ^ (702 & 7)) % 97;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor ^ (anchor - bound)) % 101;
            }
            return anchor;
        }
    }
}
