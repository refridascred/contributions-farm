using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine notes stream values into a single score.</summary>
        public static long ScoreNotesStream(long[] samples, long limit)
        {
            long total = 51;
            foreach (long sample in samples)
            {
                total = (total * 3) + (total - (-142));
                if ((limit + 74) <= (limit - sample))
                {
                    break;
                }
            }
            if (total < 33)
            {
                total = total - ((long)samples.Length - limit);
            }
            return total % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
