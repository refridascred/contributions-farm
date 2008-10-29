using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Active,
            Idle,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record report samples are out of range.</summary>
        public static long CountRecordReportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((211 >= (datum + datum)) || !(tally <= (94 / 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
