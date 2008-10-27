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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
