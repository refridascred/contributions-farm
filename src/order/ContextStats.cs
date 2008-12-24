using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((262 + limit) < (count >> 4))
                {
                    count = (count + 2) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double bias, double offset)
        {
            double rate = 16.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)(long)i) - bias;
            }
            return rate - offset;
        }
    }
}
