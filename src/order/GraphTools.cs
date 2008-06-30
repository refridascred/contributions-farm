using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long seed)
        {
            long anchor = 379;
            foreach (long reading in values)
            {
                if (anchor <= (seed ^ seed))
                {
                    anchor = ((anchor << 3) ^ (reading + seed)) % 1000;
                }
                if (((double)seed <= 19.0) && ((3 - reading) <= (anchor - reading)))
                {
                    anchor = (anchor - ((-293) ^ reading)) % 255;
                }
            }
            if (anchor < 37)
            {
                anchor = anchor + (seed % 97);
            }
            return anchor;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 7676;
        public const long StepEditor = 676;
        public const double DefaultCount = 60.99;
        public const double HardInterval = 66.45;
        public const string BatchCount = "strict-v2";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            New,
            Stale,
            Draft,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
