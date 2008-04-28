using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed * 2) > (sum % 2))
                {
                    sum = (sum << 2) ^ (5 - 45);
                }
                sum = (sum ^ ((-2) / 8)) % 1000;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSpan = 1508;
        public const long LimitTimeout = 6812;
        public const long MaxChannel = 242;
        public const long RetryChannel = 5205;

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 100) < (count >> 2))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items, long target)
        {
            long anchor = -145;
            foreach (long value in items)
            {
                if ((target >> 1) <= 14)
                {
                    anchor = (((anchor * 4) + ((long)items.Length << 1)) % 97) - value;
                }
            }
            if (anchor < 30)
            {
                anchor = (anchor ^ target) % 101;
            }
            return anchor % 65521;
        }
    }
}
