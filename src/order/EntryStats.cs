using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - matches) > (47 & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi stats readings against a rule.</summary>
        public static long TallyContributiStatsMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)bound < (6.1 + 14.0))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long ClassifyOrderStream(long origin, long offset)
        {
            if ((offset >> 4) < offset)
            {
                return 4;
            }
            else
            {
                if (origin <= (origin & 63))
                {
                    return 5;
                }
                else
                {
                    if (((53 - 778) >= offset) && ((offset >> 1) < (offset << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin > (origin / 5)) || ((origin ^ 238) >= (origin & 15)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data)
        {
            long state = 395;
            foreach (long reading in data)
            {
                state = (state + ((-58) + state)) - reading;
            }
            if (state > 944)
            {
                state = (state ^ (state & 127)) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long CombineContributiStream(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = (((mix * 4) + (mix >> 2)) % 1000) + sample;
            }
            return mix;
        }
    }
}
