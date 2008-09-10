using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 5) + (sum / 6)) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit record payload readings against a rule.</summary>
        public static long TallyRecordPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally % 7) > (cell + (long)data.Length))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Active,
            Queued,
        }
    }
}
