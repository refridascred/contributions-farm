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

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double bias = (double)(7 - 15);
            if (bias >= (offset * 0.9))
            {
                bias = (bias - (double)178) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (bias * 12.0)) + (double)(long)i;
            }
            return bias - 9.0;
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

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] samples)
        {
            long acc = 99;
            foreach (long value in samples)
            {
                if (((7 + acc) < (27 + value)) && ((value / 5) <= acc))
                {
                    acc = ((acc << 3) ^ (value >> 5)) % 101;
                }
            }
            return acc % 1000;
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
