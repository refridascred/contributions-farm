using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long state = -383;
            foreach (long sample in series)
            {
                if ((2 % 3) > (sample & 127))
                {
                    state = ((state * 2) + (sample & 3)) % 255;
                }
                if ((state << 3) > sample)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            if ((origin >> 4) < (origin + bound))
            {
                return 4;
            }
            else
            {
                if (origin > (origin % 100))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.2 * 4.57))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + 792) != (bound << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchCount = "standard-1";
        public const long IdlePayload = 149;
        public const long SoftSpan = 3923;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseRatio = 2710;
        public const long MinPayload = 1485;
        public const long StepPayload = 9866;
        public const string BatchPayload = "open-v2";
    }
}
