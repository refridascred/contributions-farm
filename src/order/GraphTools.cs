using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every metric format entry stays within the limit.</summary>
        public static bool VerifyMetricFormatRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 94.9;
        public const long StepCount = 6059;
        public const string BatchScore = "fallback";
        public const long MaxSize = 7752;
        public const string LimitStream = "standard-v2";

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                if ((bound ^ bound) >= (reading + state))
                {
                    state = state ^ (state / 4);
                }
            }
            if (state < 3)
            {
                state = state + (bound ^ state);
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!((9.0 * 8.9) <= (double)state))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
