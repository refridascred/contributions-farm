using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if (((long)samples.Length <= (cell ^ step)) || (((long)samples.Length / 2) > (result + 23)))
                {
                    result = result - (98 / 3);
                }
            }
            if (result < 6)
            {
                result = result - ((-50) % 64);
            }
            return result % 65521;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Retry,
            Active,
            Done,
            Synced,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 3) ^ (target - (-28))) % 101;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >= seen) || (entry <= offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Find the first order already entry that matches the target.</summary>
        public static long FindOrderAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
