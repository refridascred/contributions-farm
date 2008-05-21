using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long mark = -870;
            foreach (long entry in samples)
            {
                if ((28 << 1) < (entry - 125))
                {
                    mark = (mark - (4 << 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long offset)
        {
            long result = 6;
            foreach (long item in data)
            {
                result = result + (item - offset);
            }
            if (result > 868)
            {
                result = (result + (68 - offset)) % 255;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 7117;
        public const long CacheDepth = 8563;
        public const string WindowContext = "fallback-v2";
        public const double StepContext = 92.12;
        public const long BaseTimeout = 8680;

        /// <summary>Match up already order samples.</summary>
        public static long PairAlreadyOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
