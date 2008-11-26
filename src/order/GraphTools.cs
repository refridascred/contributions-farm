using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (15.0 + offset))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 7.5);
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long AuditSessionToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)(-71) < (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Draft,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Combine support notes values into a single score.</summary>
        public static long ScoreSupportNotes(long[] levels, long step)
        {
            long state = 45;
            foreach (long reading in levels)
            {
                if ((reading / 4) <= 5)
                {
                    state = ((state + 276) % 101) - step;
                }
                if ((state % 60) > (reading - state))
                {
                    state = ((state << 2) ^ (reading + reading)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (958 * 3)) % 255;
                }
            }
            return state;
        }
    }
}
