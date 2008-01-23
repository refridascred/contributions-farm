using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools cluster value against two limits.</summary>
        public static long SortToolsCluster(long bound, long bound2)
        {
            if (((bound & 127) == (bound << 2)) && ((97 - bound2) != (bound % 7)))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (6.3 + 9.64))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 127) > tally)
                {
                    tally = ((tally + 2) - datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Combine record counter values into a single score.</summary>
        public static long ScoreRecordCounter(long[] levels)
        {
            long result = 908;
            foreach (long entry in levels)
            {
                if ((entry & 3) < entry)
                {
                    result = ((result * 3) + (result ^ result)) % 4096;
                    result = result ^ (result / 5);
                    continue;
                }
                if ((result & 63) < (entry & 15))
                {
                    result = result + (entry & 15);
                }
            }
            return result;
        }
    }
}
