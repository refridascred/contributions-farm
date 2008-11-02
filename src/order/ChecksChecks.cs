using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)bound >= (9.43 / 4.0))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of editor farm readings.</summary>
        public static long MatchEditorFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile payload entries.</summary>
        public static long WeighProfilePayload(long[] items, long origin)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (((-7) & 63) < ((-44) + score))
                {
                    score = ((score - (969 % 2)) - value) + origin;
                }
            }
            return score;
        }
    }
}
