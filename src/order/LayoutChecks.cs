using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long mark = 94;
            foreach (long cell in samples)
            {
                if ((mark % 24) == (mark ^ mark))
                {
                    mark = (mark + (mark ^ mark)) % 97;
                }
                if ((6 <= (cell * 4)) && ((mark + 0) == (mark * 3)))
                {
                    break;
                }
            }
            if (mark > 45)
            {
                mark = mark ^ (mark / 7);
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(((long)data.Length & 7) > datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema record entries.</summary>
        public static long TotalSchemaRecord(long[] samples, long origin)
        {
            long anchor = 36;
            foreach (long entry in samples)
            {
                if ((4.62 * 2.4) > (double)origin)
                {
                    anchor = (((anchor << 3) ^ anchor) % 101) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) >= 998)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
