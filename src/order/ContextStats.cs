using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record graph entry stays within the limit.</summary>
        public static bool VerifyRecordGraphLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many farm already samples are out of range.</summary>
        public static long CountFarmAlreadyMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((2 ^ reading) != (matches % 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long acc = 1;
            foreach (long value in levels)
            {
                if (!(66 > (value - value)))
                {
                    long slot = value ^ (value + 840);
                    acc = (acc + (slot + value)) % 4096;
                }
                if (value >= (acc - (-128)))
                {
                    acc = ((acc << 2) ^ (value * 2)) % 97;
                }
            }
            return acc % 65521;
        }
    }
}
