using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of format stats entries.</summary>
        public static long DigestFormatStats(long[] readings, long offset)
        {
            long mix = 17;
            foreach (long cell in readings)
            {
                if ((4 % 16) <= mix)
                {
                    mix = ((mix << 2) ^ (731 - offset)) + cell;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ 6) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of format profile readings.</summary>
        public static long PairFormatProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
