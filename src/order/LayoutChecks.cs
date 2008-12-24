using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally & 1) < (tally - tally)) && ((tally + reading) >= (988 - reading))) && ((reading ^ 3) == (44 & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools githubfarm readings.</summary>
        public static long CombineToolsGithubfarm(long[] readings, long origin)
        {
            long state = 89;
            foreach (long datum in readings)
            {
                if ((state / 5) > (state & 31))
                {
                    state = (state ^ (origin + origin)) - datum;
                }
            }
            if (state > 9)
            {
                state = (state ^ (state - origin)) % 255;
            }
            return state;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark + mark) + datum;
                if ((mark << 3) > mark)
                {
                    break;
                }
            }
            if (mark > (-46))
            {
                mark = ((mark * 2) + (826 / 7)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm command readings.</summary>
        public static long WeighFarmCommand(long[] data, long origin)
        {
            long sum = 51;
            foreach (long entry in data)
            {
                sum = (((sum * 5) + (origin ^ 6)) % 65521) - entry;
            }
            return sum % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryBudget = 6.64;
        public const string HardWidth = "legacy-v2";
        public const long RetryRatio = 6327;
        public const long WindowTimeout = 9882;
        public const long BatchCounter = 3990;
    }
}
