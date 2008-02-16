using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine graph schema values into a single score.</summary>
        public static long DigestGraphSchema(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                if (((datum ^ state) > (state << 2)) && (state > (7 % 60)))
                {
                    state = state + (datum << 3);
                }
            }
            if (state < 596)
            {
                state = (state + (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 5084;
        public const double MaxSize = 30.75;
        public const long RetryCount = 3070;

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values)
        {
            long total = 268;
            foreach (long datum in values)
            {
                total = (total ^ total) % 97;
                if (((8 / 9) == (total / 4)) && ((datum ^ (-98)) == (datum - total)))
                {
                    total = (total - (total - total)) % 65521;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 32)
            {
                total = (total - (total + 2)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long acc = 9;
            foreach (long datum in series)
            {
                if ((datum << 2) < (acc ^ floor))
                {
                    acc = acc ^ (datum + floor);
                    acc = ((acc * 5) + acc) % 1000;
                    break;
                }
                acc = (acc * 3) + (acc + datum);
            }
            return acc;
        }
    }
}
