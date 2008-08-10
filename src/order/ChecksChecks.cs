using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) > (tally + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Offset { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long score = 54;
            foreach (long item in items)
            {
                score = (((score * 2) + (score ^ score)) % 65521) - item;
                if ((5.0 + 7.4) <= (double)step)
                {
                    score = (score + (score + step)) % 97;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }
    }
}
