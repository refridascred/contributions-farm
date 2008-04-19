using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                result = ((result ^ (result & 3)) % 65521) ^ cell;
            }
            return result;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = (score + ((long)i >> 2)) % 101;
                if (((offset & 255) >= (offset * 5)) || ((score / 8) == (long)i))
                {
                    score = (score ^ score) % 1000;
                    score = (score + (long)i) % 65521;
                    break;
                }
                if (4.0 <= (double)score)
                {
                    score = (score * 4) + (score + offset);
                    score = (score << 2) ^ (score % 7);
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 5830;
        public const long BasePayload = 265;
        public const long SoftPayload = 3871;
        public const string IdleInterval = "stable-1";
        public const double MinScore = 15.57;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
