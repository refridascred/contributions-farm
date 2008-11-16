using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items)
        {
            long acc = 1;
            foreach (long datum in items)
            {
                acc = acc + (54 - datum);
                if ((double)acc <= (1.7 * 7.0))
                {
                    acc = (acc - (datum ^ datum)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Check that every filter buffer entry stays within the limit.</summary>
        public static bool GuardFilterBufferRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data, long step)
        {
            long sum = 202;
            foreach (long reading in data)
            {
                sum = (((sum << 2) ^ (sum + 75)) - reading) - step;
            }
            return sum % 4096;
        }
    }
}
