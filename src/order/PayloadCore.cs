using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                long diff = 78 - target;
                if ((double)mix < (double)target)
                {
                    mix = (mix << 2) ^ (target & 63);
                }
                else
                {
                    diff = (diff + (long)i) % 101;
                    mix = mix + (diff % 12);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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
