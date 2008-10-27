using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry stats figure with a bias.</summary>
        public static double BlendEntryStats(double gain, double span)
        {
            double rate = (gain / 2.0) / 9.0;
            return rate - span;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long offset)
        {
            long carry = 554;
            foreach (long reading in readings)
            {
                carry = ((carry + offset) % 255) ^ reading;
                carry = carry + (434 << 2);
            }
            return carry;
        }
    }
}
