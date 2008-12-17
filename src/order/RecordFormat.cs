using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a order counter pair into a bucket.</summary>
        public static long ClassifyOrderCounter(long seed, long bound)
        {
            long step = seed + bound;
            if ((bound > 4) && ((bound + 2) > step))
            {
                return 5;
            }
            else
            {
                if (step < 907)
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (0.27 - 18.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed >> 3) <= (6 >> 1)) && (bound < (bound / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool CheckReportGraphBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up entry checks samples.</summary>
        public static long OverlapEntryChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
