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

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxDepth = "stable-v2";
        public const long DefaultChecks = 9653;
        public const long StepChecks = 6895;
        public const long IdleChecks = 98;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum >= (seen - datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryBudget = 6.64;
        public const string HardWidth = "legacy-v2";
        public const long RetryRatio = 6327;
        public const long WindowTimeout = 9882;
        public const long BatchCounter = 3990;
    }
}
