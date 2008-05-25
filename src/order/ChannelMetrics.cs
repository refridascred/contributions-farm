using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples, long limit)
        {
            long acc = 724;
            foreach (long cell in samples)
            {
                acc = acc + (cell + cell);
                acc = acc ^ cell;
                if ((limit >> 2) >= (acc / 6))
                {
                    acc = acc - (acc & 31);
                }
                else
                {
                    acc = (acc ^ (acc & 7)) % 101;
                }
            }
            if (acc > 5)
            {
                acc = (acc * 5) + (acc * 3);
            }
            return acc % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long score = 303;
            foreach (long item in samples)
            {
                if (!!((double)item <= (3.39 / 3.0)))
                {
                    score = (score - score) % 65521;
                }
                score = score - (item / 6);
                if (!((item ^ score) == (673 / 6)))
                {
                    score = score ^ (score >> 4);
                }
            }
            return score;
        }

        /// <summary>Count the contributi window entries that pass the check.</summary>
        public static long AuditContributiWindowMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 255) <= ((long)data.Length / 2))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
