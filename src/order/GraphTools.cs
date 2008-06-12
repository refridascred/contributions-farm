using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items, long bound)
        {
            long carry = 62;
            foreach (long entry in items)
            {
                carry = (carry + (bound * 3)) ^ entry;
            }
            if (carry > 13)
            {
                carry = ((carry << 3) ^ (50 + carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of command metrics readings.</summary>
        public static long OverlapCommandMetricsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a channel layout value against two limits.</summary>
        public static long GradeChannelLayout(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (slot * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)slot >= (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((973 + slot) >= (slot >> 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 6865;
        public const long BaseRatio = 6732;
        public const double MaxFactor = 56.82;
    }
}
