using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long limit)
        {
            if ((double)120 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((seed % 2) >= (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit - (-5)) < (-5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 3) >= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= (sample * 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] series, long bound)
        {
            long acc = 21;
            foreach (long item in series)
            {
                if ((item & 3) == (bound / 5))
                {
                    acc = acc + (bound >> 3);
                }
            }
            if (acc > 891)
            {
                acc = (acc - (bound % 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of entry format entries.</summary>
        public static long TallyEntryFormat(long[] values, long bound)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                if ((double)bound != (double)reading)
                {
                    mark = mark ^ (mark >> 3);
                }
                else
                {
                    mark = (mark + reading) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
