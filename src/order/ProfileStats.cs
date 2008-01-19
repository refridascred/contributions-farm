using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum ^ datum) < (tally * 3)) || ((double)tally >= (7.4 - 7.94))) || ((datum + 848) == (datum << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 2566;
        public const long BatchScore = 3486;
        public const long IdleFilter = 2277;
        public const long LimitDepth = 6326;
    }
}
