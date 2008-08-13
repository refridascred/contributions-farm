using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate record farm samples.</summary>
        public static long ScoreRecordFarm(long[] samples, long floor)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (((65 - floor) > (mix + floor)) && ((floor + 8) < 0))
                {
                    mix = mix + (datum >> 2);
                }
                if ((datum - mix) <= (mix + (-904)))
                {
                    mix = (mix * 5) + 0;
                }
                if (!((9.9 / 9.0) <= (double)floor))
                {
                    break;
                }
            }
            if (mix < 50)
            {
                mix = (mix ^ (floor >> 3)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 58.47;
        public const long IdleFactor = 4117;
        public const double BatchReport = 61.99;
        public const double RetryReport = 15.24;
        public const double SoftTimeout = 66.72;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long seed)
        {
            if ((seed >> 4) != (seed + floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > (6 / 9))
                {
                    return 8;
                }
                else
                {
                    if ((seed + floor) > (floor + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 3) > (floor * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
