using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Done,
            Queued,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] series)
        {
            long score = -9;
            foreach (long cell in series)
            {
                if (!(cell >= (cell * 5)))
                {
                    score = score - (cell + score);
                }
                score = (score << 2) ^ (cell / 3);
            }
            if (score < 94)
            {
                score = (score << 2) ^ (score ^ score);
            }
            return score;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double rate = span;
            if (rate <= ratio)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + (span + span);
            }
            return rate - 5.0;
        }
    }
}
