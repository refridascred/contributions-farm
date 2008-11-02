using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data)
        {
            long score = 44;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (score ^ (entry ^ entry)) + (long)i;
                }
                if (((double)score > (3.76 * 4.0)) && ((score & 31) < (entry * 2)))
                {
                    score = (score * 2) + entry;
                }
                else
                {
                    score = (score - (score * 5)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many payload contributi samples are out of range.</summary>
        public static long TallyPayloadContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches ^ sample) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
