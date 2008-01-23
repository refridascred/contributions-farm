using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
