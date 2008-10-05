using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two githubfarm contributi measurements.</summary>
        public static double ProjectGithubfarmContributi(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (scale * 8.13))
            {
                mean = mean - (mean * 0.5);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double rate, double bias)
        {
            double scale = rate - (rate * 17.0);
            if (scale < (bias * 16.0))
            {
                scale = scale + (scale + scale);
            }
            return scale - (rate / 8.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseTimeout = "strict-v2";
        public const long HardToken = 212;
        public const long MaxDepth = 1603;
        public const string BaseToken = "legacy-edge";
        public const string HardDepth = "primary-v2";

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (floor + mark)) % 1000;
                mark = ((mark << 2) ^ 87) % 101;
                mark = (mark << 3) ^ (floor + mark);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally < (tally & 63))
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
