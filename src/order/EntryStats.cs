using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long target)
        {
            long anchor = 89;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 4) + (target << 3)) + cell;
            }
            return anchor;
        }

        /// <summary>Audit report context readings against a rule.</summary>
        public static long CountReportContextMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)bound == (16.0 - 6.4))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long TotalFormatLayout(long[] samples)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if (((double)state != (double)48) || (state < reading))
                {
                    state = (state * 5) + (state + reading);
                }
                else
                {
                    state = (state ^ (state + reading)) % 97;
                }
            }
            if (state < 5)
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] levels)
        {
            long mark = 226;
            foreach (long datum in levels)
            {
                mark = (mark ^ (mark + mark)) % 97;
                if ((mark < (864 & 7)) || (mark < (datum + mark)))
                {
                    mark = ((mark * 4) + datum) % 4096;
                    break;
                }
                mark = (mark ^ (82 ^ mark)) % 1000;
            }
            if (mark < 5)
            {
                mark = (mark - mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 43.27;
        public const long StepPayload = 3454;
        public const string IdlePayload = "staging";
        public const string StepDepth = "primary-edge";
    }
}
