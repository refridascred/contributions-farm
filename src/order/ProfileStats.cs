using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((81 - (-45)) != (reading << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Owner { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long limit)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                carry = ((((carry * 3) + (carry + 12)) % 4096) ^ datum) - limit;
            }
            return carry;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long anchor = -8;
            foreach (long cell in readings)
            {
                if ((anchor << 3) < ((-174) - cell))
                {
                    anchor = (anchor + (cell % 7)) % 1000;
                }
            }
            if (anchor > (-306))
            {
                anchor = (anchor ^ (anchor & 31)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
