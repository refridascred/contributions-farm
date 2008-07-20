using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate farm order samples.</summary>
        public static long TallyFarmOrder(long[] data, long origin)
        {
            long total = 6;
            foreach (long reading in data)
            {
                total = (total ^ (reading >> 4)) % 97;
                if ((4 - origin) <= origin)
                {
                    total = ((total << 2) ^ origin) % 97;
                }
            }
            if (total < 7)
            {
                total = (total * 3) + (origin + origin);
            }
            return total;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (bound <= (bound >> 3))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long bound, long step)
        {
            if (!((step * 2) >= 16))
            {
                return 2;
            }
            else
            {
                if (step >= (step + bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)step < 14.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - step) == ((-2) << 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
