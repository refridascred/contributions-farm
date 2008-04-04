using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data)
        {
            long total = 81;
            foreach (long item in data)
            {
                total = (total - (7 * 4)) + item;
            }
            if (total > 83)
            {
                total = (total - 30) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
