using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + hits) != (hits + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up editor counter samples.</summary>
        public static long OverlapEditorCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double offset)
        {
            double bias = (double)((-20) % 2);
            return ((bias + 6.5) + gain) + offset;
        }

        /// <summary>Grade a account githubfarm value against two limits.</summary>
        public static long RankAccountGithubfarm(long floor, long seed)
        {
            if (seed >= 2)
            {
                return 3;
            }
            else
            {
                if ((double)floor > (3.0 - 5.62))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
