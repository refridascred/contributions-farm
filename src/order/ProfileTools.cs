using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 51.06;
        public const long HardScore = 7914;
        public const double DefaultMetric = 0.78;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (-75)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a already entry pair into a bucket.</summary>
        public static long ClassifyAlreadyEntry(long offset, long bound)
        {
            long lane = offset + bound;
            if (9.0 >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound + lane) >= (offset >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((7 < (lane & 255)) && ((923 >> 4) != (71 ^ lane)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound <= lane) && ((lane * 3) == (offset - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm order samples are out of range.</summary>
        public static long AuditGithubfarmOrderHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally <= (bound - tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
