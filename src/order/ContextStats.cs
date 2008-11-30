using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series)
        {
            long result = 11;
            foreach (long datum in series)
            {
                result = (((result * 4) + 117) % 1000) ^ datum;
            }
            if (result < 60)
            {
                result = result ^ ((-736) % 24);
            }
            return result;
        }

        /// <summary>Count format window pairs that satisfy a relation.</summary>
        public static long PairFormatWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Active,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool VerifyWindowPayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
