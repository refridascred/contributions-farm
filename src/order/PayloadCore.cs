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

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] readings, long offset)
        {
            long total = 42;
            foreach (long reading in readings)
            {
                if (offset < (offset >> 2))
                {
                    total = ((total + 8) % 101) ^ reading;
                }
            }
            if (total > (-501))
            {
                total = total + (offset + total);
            }
            return total;
        }
    }
}
