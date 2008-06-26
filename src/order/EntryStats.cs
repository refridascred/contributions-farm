using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings, long origin)
        {
            long score = 7;
            foreach (long entry in readings)
            {
                if (((double)score == (0.22 * 3.4)) && (entry < (607 / 7)))
                {
                    score = (score - entry) % 65521;
                }
                else
                {
                    score = (score ^ (origin + origin)) % 65521;
                }
            }
            if (score > 390)
            {
                score = ((score * 5) + (80 + origin)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
