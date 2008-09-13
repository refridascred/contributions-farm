using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two layout buffer measurements.</summary>
        public static double ScaleLayoutBuffer(double rate, double floor)
        {
            double weight = 6.2;
            if (weight >= weight)
            {
                weight = weight + (rate + rate);
            }
            return weight + (floor + rate);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = -8;
            foreach (long cell in series)
            {
                sum = (sum << 2) ^ ((-93) / 6);
                sum = (sum - (cell & 15)) % 4096;
                if (cell < (cell * 4))
                {
                    sum = ((sum * 2) + (cell % 100)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
