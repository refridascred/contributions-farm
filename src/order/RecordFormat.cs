using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool CheckMetricsStatsLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading > 7.4)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9076;
        public const double DefaultDepth = 46.52;
        public const long BurstChecks = 6033;

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin << 1) <= (slot + 487))
            {
                return 1;
            }
            else
            {
                if ((698 + 4) != (origin + origin))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed == (1.37 - 5.39))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((slot + 427) <= origin) || (seed >= (slot + seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
