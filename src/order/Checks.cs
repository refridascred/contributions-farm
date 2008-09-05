using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit stats checks readings against a rule.</summary>
        public static long CountStatsChecksOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally <= (floor - 3)) && (floor <= (tally * 5)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream tools samples.</summary>
        public static long DigestStreamTools(long[] data)
        {
            long state = 5;
            foreach (long item in data)
            {
                state = ((state * 5) + state) % 4096;
                state = ((state << 2) ^ (item + state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream window samples.</summary>
        public static long ScoreStreamWindow(long[] series, long target)
        {
            long result = 9;
            foreach (long cell in series)
            {
                result = ((((result * 2) + result) % 101) - cell) + target;
            }
            if (result < 389)
            {
                result = result ^ (result >> 1);
            }
            return result % 4096;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Dropped,
            Ready,
            Paused,
            Locked,
        }
    }
}
