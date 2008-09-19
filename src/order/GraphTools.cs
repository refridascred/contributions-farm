using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                if ((0.46 / 9.0) >= (double)mark)
                {
                    mark = ((mark * 4) + mark) ^ value;
                }
            }
            if (mark < 8)
            {
                mark = (mark + (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings, long limit)
        {
            long carry = 7;
            foreach (long reading in readings)
            {
                if ((carry + carry) > (long)readings.Length)
                {
                    carry = (carry - ((long)readings.Length / 4)) + reading;
                }
                carry = (carry - (limit % 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Synced,
            Closed,
        }
    }
}
