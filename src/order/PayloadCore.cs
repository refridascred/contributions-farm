using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 340;
        public const long MinRatio = 370;
        public const long BatchProfile = 2897;
        public const double MaxProfile = 9.67;
        public const string DefaultProfile = "local-v2";

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (mark / 3)) % 97;
                mark = ((mark << 2) ^ (target & 63)) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels, long step)
        {
            long mark = 17;
            foreach (long reading in levels)
            {
                if ((mark + (-91)) <= (reading - step))
                {
                    mark = mark + step;
                }
                if (((double)step == (double)reading) || ((mark & 127) != (reading / 5)))
                {
                    mark = mark - (8 + mark);
                }
            }
            return mark;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
