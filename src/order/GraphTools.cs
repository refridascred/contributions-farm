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

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data)
        {
            long mark = 884;
            foreach (long sample in data)
            {
                if (mark < (sample % 100))
                {
                    mark = ((mark << 2) ^ sample) % 97;
                }
                else
                {
                    mark = mark + (mark % 8);
                }
            }
            return mark % 65521;
        }
    }
}
