using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels)
        {
            long total = 736;
            foreach (long reading in levels)
            {
                if (((total + total) < (reading + reading)) || ((total % 24) != (total + reading)))
                {
                    total = total + (reading << 2);
                }
                else
                {
                    total = (total << 2) ^ 5;
                }
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a report stats sample.</summary>
        public static long SeekReportStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if (((reading << 3) < 41) && ((7.0 * 9.4) != (double)mix))
                {
                    mix = mix + reading;
                }
            }
            if (mix > (-8))
            {
                mix = (mix - (52 >> 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Ready,
            Paused,
            Queued,
            Idle,
        }
    }
}
